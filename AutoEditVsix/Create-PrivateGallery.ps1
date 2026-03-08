param(
  [Parameter(Mandatory = $true)]
  [string]$GalleryBaseUrl,

  [string]$Configuration = "Release",

  [string]$OutputDirectory = "PrivateGallery"
)

$projectDir = Split-Path -Parent $MyInvocation.MyCommand.Path
$manifestPath = Join-Path $projectDir "source.extension.vsixmanifest"
$vsixPath = Join-Path $projectDir "bin\$Configuration\AutoEditVsix.vsix"
$galleryDir = Join-Path $projectDir $OutputDirectory

if (!(Test-Path $manifestPath)) {
  throw "Manifest file not found: $manifestPath"
}

if (!(Test-Path $vsixPath)) {
  throw "VSIX package not found: $vsixPath"
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

New-Item -ItemType Directory -Path $galleryDir -Force | Out-Null
Copy-Item -Path $vsixPath -Destination (Join-Path $galleryDir "AutoEditVsix.vsix") -Force

$updated = (Get-Date).ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ")
$galleryBaseUrl = $GalleryBaseUrl.TrimEnd('/')
$vsixUrl = "$galleryBaseUrl/AutoEditVsix.vsix"

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
    <link rel="enclosure" type="application/octet-stream" href="$vsixUrl" />
  </entry>
</feed>
"@

$atomPath = Join-Path $galleryDir "Atom.xml"
Set-Content -Path $atomPath -Value $atom -Encoding UTF8

Write-Host "Private gallery created: $galleryDir"
Write-Host "Upload these files to your private host:"
Write-Host " - $atomPath"
Write-Host " - $(Join-Path $galleryDir 'AutoEditVsix.vsix')"
