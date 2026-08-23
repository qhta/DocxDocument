$ErrorActionPreference = 'Stop'
$root = 'D:\OneDrive\VS\Projects\DocxDocument\DocumentModel.InOpenXml'
$files = Get-ChildItem -Path $root -Recurse -Filter *.cs | Where-Object { $_.FullName -notmatch '\\(bin|obj)\\' }

$changes = New-Object System.Collections.Generic.List[object]

function Remove-NullableSuffix([string]$typeName) {
	$t = $typeName.Trim()
	if ($t.EndsWith('?')) { return $t.Substring(0, $t.Length - 1).Trim() }
	return $t
}

function Get-MemberNameFromNameof([string]$attrArgs) {
	$m = [regex]::Match($attrArgs, 'nameof\(([^\)]+)\)')
	if (-not $m.Success) { return $null }
	$expr = $m.Groups[1].Value.Trim()
	$parts = $expr -split '\.'
	if ($parts.Length -lt 2) { return $null }
	return $parts[-1].Trim()
}

function Get-OpenXmlElementTypeFromTypeof([string]$attrArgs) {
	$m = [regex]::Match($attrArgs, 'typeof\(([^\)]+)\)')
	if (-not $m.Success) { return $null }
	return $m.Groups[1].Value.Trim()
}

$processed = 0
foreach ($file in $files) {
	$processed++
	if (($processed % 100) -eq 0) { Write-Output "processed $processed/$($files.Count)" }

	$text = [System.IO.File]::ReadAllText($file.FullName)
	if ($text -notmatch '\[OpenXmlType\(') { continue }

	$lines = $text -split "`r?`n"
	$fileChanged = $false

	$currentClass = ''
	$currentClassOpenXmlType = ''
	$currentClassIsGeneric = $false

	$pendingAttrKind = $null
	$pendingAttrArgs = $null

	for ($i = 0; $i -lt $lines.Length; $i++) {
		$line = $lines[$i]

		$mc = [regex]::Match($line, '\bclass\s+(\w+)\s*(<[^>]+>)?\s*:\s*[^\n]*?ModelElement\s*<\s*([^>]+)\s*>')
		if ($mc.Success) {
			$currentClass = $mc.Groups[1].Value.Trim()
			$currentClassIsGeneric = -not [string]::IsNullOrWhiteSpace($mc.Groups[2].Value)
			$currentClassOpenXmlType = $mc.Groups[3].Value.Trim()
		}

		$ma = [regex]::Match($line, '\[OpenXml(Property|Element)\((.+)\)\]')
		if ($ma.Success) {
			$pendingAttrKind = $ma.Groups[1].Value
			$pendingAttrArgs = $ma.Groups[2].Value.Trim()
			continue
		}

		if ($null -eq $pendingAttrKind) { continue }
		if ($currentClassIsGeneric) { $pendingAttrKind = $null; $pendingAttrArgs = $null; continue }
		if ([string]::IsNullOrWhiteSpace($currentClassOpenXmlType)) { $pendingAttrKind = $null; $pendingAttrArgs = $null; continue }

		$mp = [regex]::Match($line.Trim(), '^public\s+(?:(?:new|override|virtual|sealed|static|required|unsafe|readonly)\s+)*(?<type>[^\{=]+?)\s+(?<name>\w+)\s*(\{|=>)')
		if (-not $mp.Success) { continue }

		$propType = $mp.Groups['type'].Value.Trim()
		$propName = $mp.Groups['name'].Value.Trim()

		$scanEnd = [Math]::Min($lines.Length - 1, $i + 35)
		$getterLine = -1
		$fieldName = $null

		for ($k = $i; $k -le $scanEnd; $k++) {
			$l = $lines[$k]
			if ($l -match 'get\s*=>\s*(_\w+)\s*;') {
				$getterLine = $k
				$fieldName = $matches[1]
				break
			}
			if ($l -match 'return\s+(_\w+)\s*;') {
				$getterLine = $k
				$fieldName = $matches[1]
				break
			}
			if ($k -gt $i + 12 -and $l -match '^\s*private\s+') {
				break
			}
		}

		if ($getterLine -lt 0 -or [string]::IsNullOrWhiteSpace($fieldName)) {
			$pendingAttrKind = $null
			$pendingAttrArgs = $null
			continue
		}

		if ($lines[$getterLine] -match '\?\?=' -or $lines[$getterLine] -match 'GetProperty<' -or $lines[$getterLine] -match 'GetElement<') {
			$pendingAttrKind = $null
			$pendingAttrArgs = $null
			continue
		}

		$loadExpr = $null
		if ($pendingAttrKind -eq 'Property') {
			$memberName = Get-MemberNameFromNameof $pendingAttrArgs
			if ($null -ne $memberName) {
				$loadExpr = "GetProperty<$propType>((GetUpdatableElement() as $currentClassOpenXmlType)?.$memberName)"
			}
		}
		elseif ($pendingAttrKind -eq 'Element') {
			$openXmlElementType = Get-OpenXmlElementTypeFromTypeof $pendingAttrArgs
			if ($null -ne $openXmlElementType) {
				$modelType = Remove-NullableSuffix $propType
				$loadExpr = "GetElement<$modelType, $openXmlElementType>(GetUpdatableElement() as DX.OpenXmlCompositeElement)"
			}
		}

		if ([string]::IsNullOrWhiteSpace($loadExpr)) {
			$pendingAttrKind = $null
			$pendingAttrArgs = $null
			continue
		}

		$replacement = "$fieldName ??= $loadExpr"
		$oldLine = $lines[$getterLine]
		$newLine = $oldLine

		if ($oldLine -match 'get\s*=>\s*' + [regex]::Escape($fieldName) + '\s*;') {
			$newLine = [regex]::Replace($oldLine, '(get\s*=>\s*)' + [regex]::Escape($fieldName) + '\s*;', ('$1' + $replacement + ';'))
		}
		elseif ($oldLine -match 'return\s+' + [regex]::Escape($fieldName) + '\s*;') {
			$newLine = [regex]::Replace($oldLine, 'return\s+' + [regex]::Escape($fieldName) + '\s*;', ('return ' + $replacement + ';'))
		}

		if ($newLine -ne $oldLine) {
			$lines[$getterLine] = $newLine
			$fileChanged = $true
			$changes.Add([pscustomobject]@{
					File = $file.FullName
					DeclaringType = $currentClass
					Property = $propName
					Kind = $pendingAttrKind
					Line = $getterLine + 1
				})
		}

		$pendingAttrKind = $null
		$pendingAttrArgs = $null
	}

	if ($fileChanged) {
		[System.IO.File]::WriteAllText($file.FullName, ($lines -join [Environment]::NewLine), [System.Text.UTF8Encoding]::new($false))
	}
}

$changesFile = Join-Path $root 'updated_openxml_lazy_properties_safe.csv'
$changes | Sort-Object File,DeclaringType,Property,Line -Unique | Export-Csv -Path $changesFile -NoTypeInformation -Encoding UTF8
Write-Output "Changed properties: $((Import-Csv $changesFile).Count)"
Write-Output "Saved: $changesFile"