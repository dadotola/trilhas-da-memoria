$ErrorActionPreference = 'Stop'
$raizProjeto = Split-Path $PSScriptRoot -Parent
$projeto = Join-Path $raizProjeto 'JogoDaMemoria/JogoDaMemoria.csproj'
$publicacao = Join-Path $raizProjeto 'entrega/jogo'

dotnet publish $projeto -c Release -r win-x64 --self-contained true -o $publicacao
if ($LASTEXITCODE -ne 0) { throw 'Não foi possível publicar o jogo.' }

$compilador = Get-Command 'ISCC.exe' -ErrorAction SilentlyContinue
if ($compilador) {
    $caminhoCompilador = $compilador.Source
} else {
    $caminhoCompilador = Join-Path ${env:ProgramFiles(x86)} 'Inno Setup 6/ISCC.exe'
}
if (-not (Test-Path $caminhoCompilador)) {
    throw 'Instale o Inno Setup 6 ou adicione ISCC.exe ao PATH. O jogo já foi publicado em entrega/jogo.'
}

& $caminhoCompilador (Join-Path $PSScriptRoot 'TrilhasDaMemoria.iss')
if ($LASTEXITCODE -ne 0) { throw 'Não foi possível gerar o instalador.' }
Write-Host 'Instalador criado em entrega/instalador/Instalar-TrilhasDaMemoria.exe'
