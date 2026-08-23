$ErrorActionPreference = 'Stop'
$root = 'D:\OneDrive\VS\Projects\DocxDocument\DocumentModel.InOpenXml'
$allCsFiles = Get-ChildItem -Path $root -Recurse -Filter *.cs | Where-Object { $_.FullName -notmatch '\\(bin|obj)\\' }
$files = $allCsFiles | Where-Object {
	Select-String -Path $_.FullName -Pattern '\[OpenXmlType\(' -Quiet
} | ForEach-Object { $_.FullName }
Write-Output "OpenXmlType files: $($files.Count)"

$candidates = New-Object System.Collections.Generic.List[object]

for ($fi = 0; $fi -lt $files.Count; $fi++) {
	$fp = $files[$fi]
	if ((($fi + 1) % 50) -eq 0) {
		Write-Output "scanned $($fi + 1)/$($files.Count)"
	}

	$text = Get-Content $fp -Raw
	$lines = $text -split "`r?`n"

	for ($i = 0; $i -lt $lines.Length; $i++) {
		$line = $lines[$i]
		if (-not ($line.Contains('[OpenXmlProperty(') -or $line.Contains('[OpenXmlElement('))) { continue }

		$kind = if ($line.Contains('[OpenXmlProperty(')) { 'Property' } else { 'Element' }

		$openParen = $line.IndexOf('(')
		$closeParen = $line.LastIndexOf(')')
		if ($openParen -lt 0 -or $closeParen -le $openParen) { continue }
		$attrArgs = $line.Substring($openParen + 1, $closeParen - $openParen - 1).Trim()

		$j = $i + 1
		while ($j -lt $lines.Length -and [string]::IsNullOrWhiteSpace($lines[$j])) { $j++ }
		if ($j -ge $lines.Length) { continue }

		$sig = $lines[$j].Trim()
		$mSig = [regex]::Match($sig, '^public\s+(.+?)\s+(\w+)\s*(\{|$)')
		if (-not $mSig.Success) { continue }

		$propType = $mSig.Groups[1].Value.Trim()
		$propName = $mSig.Groups[2].Value

		$k = $j
		$block = ''
		while ($k -lt $lines.Length) {
			$block += $lines[$k] + "`n"
			if ([regex]::IsMatch($lines[$k], '^\s*private\s+.+\s+_\w+\s*;')) { break }
			if ($k -gt $j + 45) { break }
			$k++
		}

		$field = $null
		$mField1 = [regex]::Match($block, 'get\s*=>\s*(_\w+)\s*;')
		if ($mField1.Success) {
			$field = $mField1.Groups[1].Value
		}
		else {
			$mField2 = [regex]::Match($block, 'get\s*\{\s*return\s+(_\w+)\s*;\s*\}')
			if ($mField2.Success) {
				$field = $mField2.Groups[1].Value
			}
		}

		if ($field) {
			$candidates.Add([pscustomobject]@{
					File = $fp
					Line = $j + 1
					Kind = $kind
					AttrArgs = $attrArgs
					PropertyType = $propType
					Property = $propName
					Field = $field
				})
		}
	}
}

$jsonPath = Join-Path $root 'candidate_properties.json'
$csvPath = Join-Path $root 'candidate_properties.csv'
$candidates | ConvertTo-Json -Depth 5 | Set-Content -Path $jsonPath -Encoding UTF8
$candidates | Export-Csv -Path $csvPath -NoTypeInformation -Encoding UTF8
Write-Output "Candidates: $($candidates.Count)"
Write-Output "Saved: $jsonPath"
Write-Output "Saved: $csvPath"