param(
  [string]$Configuration = "Release",
  [string]$FeedFolder = "D:\OneDrive\VS\Extensions",
  [int]$Port = 8080,
  [switch]$InstallServer,
  [switch]$StartServer
)

$ErrorActionPreference = "Stop"

$projectDir = Split-Path -Parent $MyInvocation.MyCommand.Path
$projectPath = Join-Path $projectDir "AutoEditVsix.csproj"
$manifestPath = Join-Path $projectDir "source.extension.vsixmanifest"
$vsixPath = Join-Path $projectDir "bin\$Configuration\AutoEditVsix.vsix"
$galleryUrl = "http://localhost:$Port"

if (!(Test-Path $projectPath)) {
  throw "Project not found: $projectPath"
}

if (!(Test-Path $manifestPath)) {
  throw "Manifest not found: $manifestPath"
}

$msbuild = Get-Command msbuild -ErrorAction SilentlyContinue
if ($null -eq $msbuild) {
  throw "msbuild was not found in PATH. Run from a Developer PowerShell for Visual Studio."
}

Write-Host "Building VSIX ($Configuration)..."
& $msbuild.Source $projectPath /t:Build /p:Configuration=$Configuration /nologo
if ($LASTEXITCODE -ne 0) {
  throw "Build failed"
}

if (!(Test-Path $vsixPath)) {
  throw "VSIX was not produced: $vsixPath"
}

[xml]$manifest = Get-Content -Path $manifestPath
$ns = New-Object System.Xml.XmlNamespaceManager($manifest.NameTable)
$ns.AddNamespace("vsix", "http://schemas.microsoft.com/developer/vsx-schema/2011")

$identity = $manifest.SelectSingleNode("/vsix:PackageManifest/vsix:Metadata/vsix:Identity", $ns)
$displayNameNode = $manifest.SelectSingleNode("/vsix:PackageManifest/vsix:Metadata/vsix:DisplayName", $ns)
$descriptionNode = $manifest.SelectSingleNode("/vsix:PackageManifest/vsix:Metadata/vsix:Description", $ns)

if ($null -eq $identity) {
  throw "Could not read Identity from manifest"
}

$extensionId = $identity.Id
$version = $identity.Version
$displayName = if ($displayNameNode -and $displayNameNode.InnerText) { $displayNameNode.InnerText } else { "AutoEditVsix" }
$summary = if ($descriptionNode -and $descriptionNode.InnerText) { $descriptionNode.InnerText } else { "AutoEdit extension update" }
$updated = (Get-Date).ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ")

New-Item -Path $FeedFolder -ItemType Directory -Force | Out-Null
$feedVsixPath = Join-Path $FeedFolder "AutoEditVsix.vsix"
$feedAtomPath = Join-Path $FeedFolder "Atom.xml"

Copy-Item -Path $vsixPath -Destination $feedVsixPath -Force

$atom = @"
<?xml version="1.0" encoding="utf-8"?>
<feed xmlns="http://www.w3.org/2005/Atom">
  <title>AutoEdit Private Gallery</title>
  <id>urn:AutoEditVsix:feed</id>
  <updated>$updated</updated>
  <entry>
    <id>$extensionId</id>
    <title>$displayName</title>
    <updated>$updated</updated>
    <summary>$summary</summary>
    <link rel="enclosure" type="application/octet-stream" href="$galleryUrl/AutoEditVsix.vsix" />
  </entry>
</feed>
"@

Set-Content -Path $feedAtomPath -Value $atom -Encoding UTF8

$serverScriptPath = Join-Path $FeedFolder "Start-LocalVsixServer.ps1"
$serverScript = @"
param([int]`$Port = $Port)
`$ErrorActionPreference = "Stop"

if (-not (Get-Command dotnet-serve -ErrorAction SilentlyContinue)) {
  dotnet tool install --global dotnet-serve
}

Write-Host "Serving VSIX feed from '$FeedFolder' at http://localhost:`$Port"
dotnet-serve --directory "$FeedFolder" --port `$Port
"@
Set-Content -Path $serverScriptPath -Value $serverScript -Encoding UTF8


  if (-not (Get-Command dotnet-serve -ErrorAction SilentlyContinue)) {
    Write-Host "Installing dotnet-serve..."
    dotnet tool install --global dotnet-serve
    if ($LASTEXITCODE -ne 0) {
      throw "Failed to install dotnet-serve"
    }
  }

Write-Host "Released $displayName v$version to: $FeedFolder"
Write-Host "Feed URL: $galleryUrl/Atom.xml"
Write-Host "Server helper: $serverScriptPath"

  if (-not (Get-Command dotnet-serve -ErrorAction SilentlyContinue)) {
    dotnet tool install --global dotnet-serve
    if ($LASTEXITCODE -ne 0) {
      throw "Failed to install dotnet-serve"
    }
  }

  Write-Host "Starting local server..."
  Start-Process -FilePath "dotnet-serve" -ArgumentList @("--directory", $FeedFolder, "--port", $Port)
  Write-Host "Local server started at $galleryUrl"
