param(
    [string]$PastaEntrega = (Join-Path (Split-Path $PSScriptRoot -Parent) 'entrega')
)

$ErrorActionPreference = 'Stop'
$raizProjeto = Split-Path $PSScriptRoot -Parent
$projeto = Join-Path $raizProjeto 'JogoDaMemoria/JogoDaMemoria.csproj'
$PastaEntrega = [IO.Path]::GetFullPath($PastaEntrega)
$publicacao = Join-Path $PastaEntrega 'jogo'
$compilacao = Join-Path $PastaEntrega 'compilacao'
$pastaInstalador = Join-Path $PastaEntrega 'instalador'

dotnet publish $projeto -c Release -r win-x64 --self-contained true --artifacts-path $compilacao -o $publicacao
if ($LASTEXITCODE -ne 0) { throw 'Não foi possível publicar o jogo.' }

$compilador = Get-Command 'ISCC.exe' -ErrorAction SilentlyContinue
if ($compilador) {
    $caminhoCompilador = $compilador.Source
} else {
    $caminhoCompilador = Join-Path $env:LOCALAPPDATA 'Programs/Inno Setup 6/ISCC.exe'
    if (-not (Test-Path $caminhoCompilador)) {
        $caminhoCompilador = Join-Path ${env:ProgramFiles(x86)} 'Inno Setup 6/ISCC.exe'
    }
}
if (-not (Test-Path $caminhoCompilador)) {
    throw "Instale o Inno Setup 6 ou adicione ISCC.exe ao PATH. O jogo foi publicado em $publicacao."
}

& $caminhoCompilador "/DPastaJogo=$publicacao" "/O$pastaInstalador" (Join-Path $PSScriptRoot 'TrilhasDaMemoria.iss')
if ($LASTEXITCODE -ne 0) { throw 'Não foi possível gerar o instalador.' }
Write-Host "Instalador criado em $pastaInstalador/Instalar-TrilhasDaMemoria.exe"
