; Abra no Inno Setup após executar gerar-instalador.ps1 no Windows.
[Setup]
AppId={{CEFA7BBE-32E8-4DD8-93E1-DA86292B53D4}
AppName=Trilhas da Memória
AppVersion=1.0.0
AppPublisher=Projeto acadêmico - Sistemas de Informação
DefaultDirName={localappdata}\Programs\Trilhas da Memória
DefaultGroupName=Trilhas da Memória
PrivilegesRequired=lowest
ArchitecturesAllowed=x64compatible
ArchitecturesInstallIn64BitMode=x64compatible
OutputDir=..\entrega\instalador
OutputBaseFilename=Instalar-TrilhasDaMemoria
Compression=lzma2
SolidCompression=yes
WizardStyle=modern
UninstallDisplayIcon={app}\JogoDaMemoria.exe

[Languages]
Name: "portuguese"; MessagesFile: "compiler:Languages\BrazilianPortuguese.isl"

[Files]
Source: "..\entrega\jogo\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs

[Icons]
Name: "{autoprograms}\Trilhas da Memória"; Filename: "{app}\JogoDaMemoria.exe"
Name: "{autodesktop}\Trilhas da Memória"; Filename: "{app}\JogoDaMemoria.exe"

[Run]
Filename: "{app}\JogoDaMemoria.exe"; Description: "Jogar Trilhas da Memória"; Flags: nowait postinstall skipifsilent
