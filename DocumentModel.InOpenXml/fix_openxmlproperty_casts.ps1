$ErrorActionPreference = 'Stop'
$root = 'D:\OneDrive\VS\Projects\DocxDocument\DocumentModel.InOpenXml'
$files = Get-ChildItem -Path $root -Recurse -Filter *.cs | Where-Object { $_.FullName -notmatch '\\(bin|obj)\\' }
$changed = New-Object System.Collections.Generic.List[object]

foreach ($file in $files) {
	$lines = [System.IO.File]::ReadAllLines($file.FullName)
	$fileChanged = $false

	for ($i = 0; $i -lt $lines.Length; $i++) {
		$line = $lines[$i]
		if ($line -notmatch '\[OpenXmlProperty\((.+)\)\]') { continue }
		$attrArgs = $matches[1]
		$mNameof = [regex]::Match($attrArgs, 'nameof\(([^\)]+)\)')
		if (-not $mNameof.Success) { continue }
		$nameOfExpr = $mNameof.Groups[1].Value.Trim()
		$parts = $nameOfExpr -split '\.'
		if ($parts.Length -lt 2) { continue }
		$openXmlType = ($parts[0..($parts.Length-2)] -join '.').Trim()
		$member = $parts[-1].Trim()
		if ([string]::IsNullOrWhiteSpace($openXmlType) -or [string]::IsNullOrWhiteSpace($member)) { continue }

		$j = $i + 1
		while ($j -lt $lines.Length -and [string]::IsNullOrWhiteSpace($lines[$j])) { $j++ }
		if ($j -ge $lines.Length) { continue }
		$sig = $lines[$j].Trim()
		$mSig = [regex]::Match($sig, '^public\s+.+\s+(\w+)\s*(\{|$)')
		if (-not $mSig.Success) { continue }
		$propName = $mSig.Groups[1].Value

		# scan within property + backing field region
		$end = [Math]::Min($lines.Length - 1, $j + 55)
		for ($k = $j; $k -le $end; $k++) {
			$old = $lines[$k]
			$pattern = 'GetProperty<(?<g>[^>]+)>\(GetUpdatableElement\(\)\?\.' + [regex]::Escape($member) + '\)'
			if ($old -match $pattern) {
				$new = [regex]::Replace($old, $pattern, 'GetProperty<${g}>((GetUpdatableElement() as ' + $openXmlType + ')?.' + $member + ')')
				if ($new -ne $old) {
					$lines[$k] = $new
					$fileChanged = $true
					$changed.Add([pscustomobject]@{ File = $file.FullName; Property = $propName; Line = $k + 1 })
				}
			}
			if ($lines[$k] -match '^\s*private\s+') { break }
		}
	}

	if ($fileChanged) {
		[System.IO.File]::WriteAllLines($file.FullName, $lines, [System.Text.UTF8Encoding]::new($false))
	}
}

$out = Join-Path $root 'fixed_openxmlproperty_casts.csv'
$changed | Sort-Object File,Property,Line -Unique | Export-Csv -Path $out -NoTypeInformation -Encoding UTF8
Write-Output "Cast fixes: $((Import-Csv $out).Count)"
Write-Output "Saved: $out"