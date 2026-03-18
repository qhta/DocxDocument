param(
    [string]$InterfacesDirectory = "WordInterfaces",
    [string]$StartFile = "GroupShapes.Methods.cs",
    [switch]$WhatIf
)

Set-StrictMode -Version Latest
$ErrorActionPreference = "Stop"

function Split-Params {
    param([string]$text)

    if ([string]::IsNullOrWhiteSpace($text)) { return @() }

    $parts = @()
    $current = ""
    $depth = 0

    foreach ($ch in $text.ToCharArray()) {
        if ($ch -eq '<') { $depth++ }
        elseif ($ch -eq '>') { if ($depth -gt 0) { $depth-- } }

        if ($ch -eq ',' -and $depth -eq 0) {
            $parts += $current.Trim()
            $current = ""
            continue
        }

        $current += $ch
    }

    if ($current.Trim().Length -gt 0) { $parts += $current.Trim() }
    return $parts
}

function To-Words {
    param([string]$name)

    $x = $name.TrimStart('@')
    $x = $x -replace '^get_', ''
    $x = $x -replace '^set_', ''
    $x = [regex]::Replace($x, '([a-z0-9])([A-Z])', '$1 $2')
    $x = $x -replace '_', ' '
    $x = $x -replace '\s+', ' '
    $x = $x.Trim().ToLowerInvariant()
    return $x
}

function Strip-Html {
    param([string]$html)
    if ([string]::IsNullOrWhiteSpace($html)) { return "" }

    $s = $html -replace '<[^>]+>', ' '
    $s = [System.Net.WebUtility]::HtmlDecode($s)
    $s = $s -replace '\s+', ' '
    return $s.Trim()
}

function Get-LearnMethodDoc {
    param(
        [string]$interfaceName,
        [string]$methodName
    )

    $iface = $interfaceName.Trim()
    $ifaceLower = $iface.ToLowerInvariant()
    $ifaceNoUnderscore = $ifaceLower.TrimStart('_')

    $methodNormalized = $methodName.TrimStart('@')
    if ($methodNormalized.StartsWith('get_')) { $methodNormalized = $methodNormalized.Substring(4) }
    elseif ($methodNormalized.StartsWith('set_')) { $methodNormalized = $methodNormalized.Substring(4) }
    $methodLower = $methodNormalized.ToLowerInvariant()

    $urls = @(
        "https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.${ifaceLower}.${methodLower}?view=word-pia",
        "https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.${ifaceNoUnderscore}.${methodLower}?view=word-pia",
        "https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.${ifaceNoUnderscore}.${methodLower}?view=office-pia"
    )

    foreach ($url in $urls | Select-Object -Unique) {
        try {
            $resp = Invoke-WebRequest -Uri $url -Method Get -TimeoutSec 20 -MaximumRedirection 5
            if (-not $resp.Content) { continue }

            $html = $resp.Content
            $result = [ordered]@{
                Url = $url
                Summary = $null
                Params = @{}
                Returns = $null
            }

            $meta = [regex]::Match($html, '<meta\s+name="description"\s+content="([^"]+)"', 'IgnoreCase')
            if ($meta.Success) {
                $summary = [System.Net.WebUtility]::HtmlDecode($meta.Groups[1].Value).Trim()
                if ($summary.Length -gt 0) { $result.Summary = $summary }
            }

            $paramMatches = [regex]::Matches(
                $html,
                '<dt[^>]*>\s*(?:<[^>]+>\s*)*(?<name>[A-Za-z_][A-Za-z0-9_]*)\s*(?:<[^>]+>\s*)*</dt>\s*<dd[^>]*>(?<desc>.*?)</dd>',
                'IgnoreCase, Singleline'
            )

            foreach ($m in $paramMatches) {
                $name = $m.Groups['name'].Value
                $desc = Strip-Html $m.Groups['desc'].Value
                if ($name -and $desc -and -not $result.Params.Contains($name)) {
                    $result.Params[$name] = $desc
                }
            }

            $returnsMatch = [regex]::Match($html, '(?is)<h[1-6][^>]*>\s*Returns\s*</h[1-6]>\s*(?<body>.*?)\s*(?:<h[1-6]|</article>)')
            if ($returnsMatch.Success) {
                $retDesc = Strip-Html $returnsMatch.Groups['body'].Value
                if ($retDesc.Length -gt 0) { $result.Returns = $retDesc }
            }

            return $result
        }
        catch {
            continue
        }
    }

    return $null
}

function Get-FallbackSummary {
    param(
        [string]$methodName,
        [string]$returnType,
        [string]$currentSummary
    )

    if ($currentSummary -match '^Adds an event handler for (.+)\.$') {
        return "Subscribes a handler to the $($Matches[1]) event."
    }

    if ($currentSummary -match '^Removes an event handler for (.+)\.$') {
        return "Unsubscribes a handler from the $($Matches[1]) event."
    }

    if ($methodName.StartsWith('get_')) { return "Returns the $(To-Words $methodName)." }
    if ($methodName.StartsWith('set_')) { return "Sets the $(To-Words $methodName)." }

    $name = $methodName.TrimStart('@')
    switch -Regex ($name) {
        '^Select$' { return "Selects the item." }
        '^Delete$' { return "Deletes the item." }
        '^Copy$' { return "Copies the item to the Clipboard." }
        '^Open$' { return "Opens the item." }
        '^Close$' { return "Closes the item." }
        '^Save$' { return "Saves the item." }
        '^Add' { return "Adds the specified item." }
        default {
            if ($returnType -eq 'void') { return "Executes the $(To-Words $name) operation." }
            if ($returnType -eq 'bool') { return "Determines whether $(To-Words $name)." }
            return "Returns the result of the $(To-Words $name) operation."
        }
    }
}

function Get-FallbackParamDesc {
    param(
        [string]$methodName,
        [string]$paramType,
        [string]$paramName
    )

    $pn = $paramName.TrimStart('@')

    if ($pn -eq 'param1' -and $methodName.StartsWith('add_')) {
        $ev = $methodName.Substring(4)
        return "The delegate to invoke when the $ev event is raised."
    }

    if ($pn -eq 'param1' -and $methodName.StartsWith('remove_')) {
        $ev = $methodName.Substring(7)
        return "The delegate to remove from the $ev event."
    }

    if ($paramType -eq 'bool') { return "Specifies whether $(To-Words $pn)." }
    return "Specifies the $(To-Words $pn)."
}

function Get-FallbackReturns {
    param(
        [string]$returnType,
        [string]$methodName
    )

    switch ($returnType) {
        'bool' { return "true if successful; otherwise, false." }
        'int' { return "An integer value returned by the operation." }
        'string' { return "The resulting string value." }
        'void' { return $null }
        default {
            $rt = $returnType
            if ($rt.Contains('<')) { $rt = $rt.Substring(0, $rt.IndexOf('<')) }
            if ($rt.Contains('.')) { $rt = $rt.Split('.')[-1] }
            return "The resulting $rt object."
        }
    }
}

$dir = Join-Path (Get-Location) $InterfacesDirectory
if (-not (Test-Path $dir)) {
    throw "Directory not found: $dir"
}

$allFiles = Get-ChildItem -Path $dir -Filter '*.Methods.cs' -File | Sort-Object Name
if (-not $allFiles) {
    throw "No .Methods.cs files found in $dir"
}

$startIndex = 0
if ($StartFile) {
    $idx = ($allFiles.Name.IndexOf($StartFile))
    if ($idx -ge 0) { $startIndex = $idx }
}

$targets = $allFiles[$startIndex..($allFiles.Count - 1)]
$filesChanged = 0
$methodsUpdated = 0

foreach ($file in $targets) {
    $lines = [System.Collections.Generic.List[string]](Get-Content $file.FullName)
    $changed = $false

    $interfaceName = [System.IO.Path]::GetFileNameWithoutExtension([System.IO.Path]::GetFileNameWithoutExtension($file.Name))

    for ($i = 0; $i -lt $lines.Count; $i++) {
        if ($lines[$i] -notmatch '^\s*///\s*<summary>') { continue }

        $sumStart = $i
        $sumEnd = $i + 1
        while ($sumEnd -lt $lines.Count -and $lines[$sumEnd] -notmatch '^\s*///\s*</summary>') { $sumEnd++ }
        if ($sumEnd -ge $lines.Count) { break }

        $sigStart = $sumEnd + 1
        while ($sigStart -lt $lines.Count -and [string]::IsNullOrWhiteSpace($lines[$sigStart])) { $sigStart++ }
        if ($sigStart -ge $lines.Count) { break }

        $sig = ""
        $sigEnd = $sigStart
        while ($sigEnd -lt $lines.Count) {
            $sig += " " + $lines[$sigEnd].Trim()
            if ($lines[$sigEnd].Trim().EndsWith(';')) { break }
            $sigEnd++
        }
        $sig = $sig.Trim()

        if ($sig -notmatch '^public\s+(.+?)\s+([A-Za-z_@][A-Za-z0-9_]*)\s*\((.*)\)\s*;\s*$') {
            $i = $sigEnd
            continue
        }

        $returnType = $Matches[1].Trim()
        $methodName = $Matches[2].Trim()
        $paramsRaw = $Matches[3].Trim()

        $indent = ([regex]::Match($lines[$sumStart], '^\s*').Value)

        $sumText = (($lines[($sumStart + 1)..($sumEnd - 1)] | ForEach-Object { $_ -replace '^\s*///\s?', '' }) -join ' ').Trim()

        $genericSummary = $sumText -match '^Performs the ' -or
                          $sumText -match '^Executes the ' -or
                          $sumText -match '^Returns the result of the ' -or
                          $sumText -match '^The ' -or
                          $sumText -match '^Adds an event handler for ' -or
                          $sumText -match '^Removes an event handler for '

        $learnDoc = $null
        if ($genericSummary) {
            $learnDoc = Get-LearnMethodDoc -interfaceName $interfaceName -methodName $methodName
            $newSummary = if ($learnDoc -and $learnDoc.Summary) { $learnDoc.Summary } else { Get-FallbackSummary -methodName $methodName -returnType $returnType -currentSummary $sumText }

            while ($sumEnd -gt $sumStart + 1) {
                $lines.RemoveAt($sumStart + 1)
                $sumEnd--
            }

            $lines.Insert($sumStart + 1, ('{0}/// {1}' -f $indent, $newSummary))
            $changed = $true
            $methodsUpdated++

            $sumEnd = $sumStart + 2
            $sigStart = $sumEnd + 1
            while ($sigStart -lt $lines.Count -and [string]::IsNullOrWhiteSpace($lines[$sigStart])) { $sigStart++ }
            $sigEnd = $sigStart
        }

        if ([string]::IsNullOrWhiteSpace($paramsRaw) -eq $false) {
            $hasParam = $false
            for ($p = $sumEnd + 1; $p -lt $sigStart; $p++) {
                if ($lines[$p] -match '^\s*///\s*<param\s+name=') { $hasParam = $true; break }
            }

            if (-not $hasParam) {
                if (-not $learnDoc) { $learnDoc = Get-LearnMethodDoc -interfaceName $interfaceName -methodName $methodName }

                $insertAt = $sumEnd + 1
                foreach ($param in (Split-Params $paramsRaw)) {
                    if ($param -match '^(.+?)\s+([A-Za-z_@][A-Za-z0-9_]*)$') {
                        $paramType = $Matches[1].Trim()
                        $paramName = $Matches[2].TrimStart('@')

                        $desc = $null
                        if ($learnDoc -and $learnDoc.Params.Contains($paramName)) {
                            $desc = $learnDoc.Params[$paramName]
                        }
                        if ([string]::IsNullOrWhiteSpace($desc)) {
                            $desc = Get-FallbackParamDesc -methodName $methodName -paramType $paramType -paramName $paramName
                        }

                        $lines.Insert($insertAt, ('{0}/// <param name="{1}">{2}</param>' -f $indent, $paramName, $desc))
                        $insertAt++
                        $sigStart++
                        $sigEnd++
                    }
                }

                $changed = $true
            }
        }

        if ($returnType -ne 'void') {
            $hasReturns = $false
            for ($r = $sumEnd + 1; $r -lt $sigStart; $r++) {
                if ($lines[$r] -match '^\s*///\s*<returns>') { $hasReturns = $true; break }
            }

            if (-not $hasReturns) {
                if (-not $learnDoc) { $learnDoc = Get-LearnMethodDoc -interfaceName $interfaceName -methodName $methodName }

                $ret = if ($learnDoc -and $learnDoc.Returns) { $learnDoc.Returns } else { Get-FallbackReturns -returnType $returnType -methodName $methodName }
                if ($ret) {
                    $lines.Insert($sigStart, ('{0}/// <returns>{1}</returns>' -f $indent, $ret))
                    $sigStart++
                    $sigEnd++
                    $changed = $true
                }
            }
        }

        $i = $sigEnd
    }

    if ($changed) {
        $filesChanged++
        if ($WhatIf) {
            Write-Host "[WhatIf] Would update $($file.Name)"
        }
        else {
            Set-Content -Path $file.FullName -Value $lines
            Write-Host "Updated $($file.Name)"
        }
    }
}

Write-Host "Done. Files changed: $filesChanged. Method docs enhanced: $methodsUpdated."
Write-Host "No build was executed by this script."
