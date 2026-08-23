$ErrorActionPreference = 'Stop'
$root = 'D:\OneDrive\VS\Projects\DocxDocument\DocumentModel.InOpenXml'
$candidateCsv = Join-Path $root 'candidate_properties.csv'
if (!(Test-Path $candidateCsv)) { throw "Missing $candidateCsv. Run scan_candidate_properties.ps1 first." }

$candidates = Import-Csv -Path $candidateCsv
$filesToProcess = $candidates | Select-Object -ExpandProperty File -Unique

$changes = New-Object System.Collections.Generic.List[object]
$processedFiles = 0

function Get-NonNullableType([string]$typeName) {
	$t = $typeName.Trim()
	if ($t.EndsWith('?')) { return $t.Substring(0, $t.Length - 1).Trim() }
	if ($t -match '^Nullable\s*<\s*(.+)\s*>$') { return $matches[1].Trim() }
	return $t
}

function Get-ClassNameAtLine($lines, [int]$lineIndex0) {
	for ($i = $lineIndex0; $i -ge 0; $i--) {
		$m = [regex]::Match($lines[$i], '\bclass\s+(\w+)')
		if ($m.Success) { return $m.Groups[1].Value }
	}
	return ''
}

foreach ($filePath in $filesToProcess) {
	$processedFiles++
	if (($processedFiles % 50) -eq 0) { Write-Output "files: $processedFiles/$($filesToProcess.Count)" }

	$normalizedFilePath = ([string]$filePath).Trim()
	if ($normalizedFilePath.EndsWith(':String')) {
		$normalizedFilePath = $normalizedFilePath.Substring(0, $normalizedFilePath.Length - 7)
	}

	if (!(Test-Path -LiteralPath $normalizedFilePath)) { continue }

	$lines = [System.IO.File]::ReadAllLines($normalizedFilePath)
	$fileChanged = $false

	# process from bottom to top to keep line positions stable enough
	$fileCandidates = $candidates | Where-Object { $_.File -eq $filePath } | Sort-Object { [int]$_.Line } -Descending

	foreach ($c in $fileCandidates) {
		$propName = $c.Property
		$fieldName = $c.Field
		$kind = $c.Kind
		$attrArgs = $c.AttrArgs
		$propType = $c.PropertyType
		$lineIdx = [Math]::Max(([int]$c.Line - 1), 0)

		# Find property declaration near recorded line.
		$declIdx = -1
		$start = [Math]::Max(0, $lineIdx - 6)
		$end = [Math]::Min($lines.Count - 1, $lineIdx + 20)
		for ($i = $start; $i -le $end; $i++) {
			if ($lines[$i] -match ('^\s*public\s+.+\s+' + [regex]::Escape($propName) + '\s*(\{|$)')) {
				$declIdx = $i
				break
			}
		}
		if ($declIdx -lt 0) { continue }

		# Find getter line/return line inside property block span.
		$getterIdx = -1
		$returnIdx = -1
		$fieldDeclIdx = -1
		$spanEnd = [Math]::Min($lines.Count - 1, $declIdx + 55)
		for ($i = $declIdx; $i -le $spanEnd; $i++) {
			if ($lines[$i] -match ('^\s*private\s+.+\s+' + [regex]::Escape($fieldName) + '\s*;')) {
				$fieldDeclIdx = $i
				break
			}
			if ($getterIdx -lt 0 -and $lines[$i] -match ('get\s*=>\s*' + [regex]::Escape($fieldName) + '\s*;')) {
				$getterIdx = $i
			}
			if ($returnIdx -lt 0 -and $lines[$i] -match ('\breturn\s+' + [regex]::Escape($fieldName) + '\s*;')) {
				$returnIdx = $i
			}
		}
		if ($fieldDeclIdx -lt 0) { continue }

		# skip if already lazy
		$alreadyLazy = $false
		$scanTo = [Math]::Min($fieldDeclIdx, $declIdx + 60)
		for ($i = $declIdx; $i -le $scanTo; $i++) {
			if ($lines[$i] -match ('get\s*=>\s*' + [regex]::Escape($fieldName) + '\s*\?\?=')) { $alreadyLazy = $true; break }
			if ($lines[$i] -match ('return\s+' + [regex]::Escape($fieldName) + '\s*\?\?=')) { $alreadyLazy = $true; break }
		}
		if ($alreadyLazy) { continue }

		$fieldDeclLine = $lines[$fieldDeclIdx]
		$isNullable = $fieldDeclLine.Contains('?') -or $propType.Contains('?')
		if (-not $isNullable) { continue }

		$loadExpr = $null
		if ($kind -eq 'Property') {
			$mNameof = [regex]::Match($attrArgs, 'nameof\(([^\)]+)\)')
			if (-not $mNameof.Success) { continue }
			$memberPath = $mNameof.Groups[1].Value.Trim()
			$member = ($memberPath -split '\.')[-1]
			if ([string]::IsNullOrWhiteSpace($member)) { continue }
			$loadExpr = "GetProperty<$propType>(GetUpdatableElement()?.$member)"
		}
		elseif ($kind -eq 'Element') {
			$mTypeof = [regex]::Match($attrArgs, 'typeof\(([^\)]+)\)')
			if (-not $mTypeof.Success) { continue }
			$openXmlType = $mTypeof.Groups[1].Value.Trim()
			if ([string]::IsNullOrWhiteSpace($openXmlType)) { continue }
			$modelType = Get-NonNullableType $propType
			$loadExpr = "GetElement<$modelType, $openXmlType>(GetUpdatableElement())"
		}

		if ([string]::IsNullOrWhiteSpace($loadExpr)) { continue }

		$replacement = "$fieldName ??= $loadExpr"

		if ($getterIdx -ge 0) {
			$oldLine = $lines[$getterIdx]
			$newLine = [regex]::Replace($oldLine, '(get\s*=>\s*)' + [regex]::Escape($fieldName) + '\s*;', ('$1' + $replacement + ';'))
			if ($newLine -ne $oldLine) {
				$lines[$getterIdx] = $newLine
				$fileChanged = $true
			}
		}
		elseif ($returnIdx -ge 0) {
			$oldLine = $lines[$returnIdx]
			$newLine = [regex]::Replace($oldLine, '\breturn\s+' + [regex]::Escape($fieldName) + '\s*;', ('return ' + $replacement + ';'))
			if ($newLine -ne $oldLine) {
				$lines[$returnIdx] = $newLine
				$fileChanged = $true
			}
		}

		if ($fileChanged) {
			$declType = Get-ClassNameAtLine $lines $declIdx
			$changes.Add([pscustomobject]@{
					File = $normalizedFilePath
					DeclaringType = $declType
					Property = $propName
					Kind = $kind
				})
		}
	}

	if ($fileChanged) {
		[System.IO.File]::WriteAllLines($normalizedFilePath, $lines, [System.Text.UTF8Encoding]::new($false))
	}
}

$changesPath = Join-Path $root 'updated_openxml_lazy_properties.csv'
$changes | Sort-Object File, DeclaringType, Property -Unique | Export-Csv -Path $changesPath -NoTypeInformation -Encoding UTF8
Write-Output "Changed properties: $((Import-Csv $changesPath).Count)"
Write-Output "Saved change list: $changesPath"