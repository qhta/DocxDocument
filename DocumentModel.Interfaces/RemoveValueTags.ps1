$projectRoot = "D:\OneDrive\VS\Projects\DocxDocument"
$csFiles = Get-ChildItem -Path $projectRoot -Filter "*.cs" -Recurse

$filesModified = 0
$totalValueTagsRemoved = 0
$totalEmptyRemarksRemoved = 0

foreach ($file in $csFiles) {
    try {
        $content = Get-Content -Path $file.FullName -Raw
        $originalContent = $content
        
        # Pattern to match <value> tags with their content (including multi-line)
        # This matches from /// <value> to </value> including everything in between
        $valuePattern = '(?ms)^\s*///\s*<value>.*?</value>\s*\r?\n'
        
        # Pattern to match empty <remarks> tags (with only whitespace)
        $emptyRemarksPattern = '(?m)^\s*///\s*<remarks>\s*\r?\n\s*///\s*</remarks>\s*\r?\n'
        
        # Count matches before removal
        $valueMatches = ([regex]$valuePattern).Matches($content)
        $emptyRemarksMatches = ([regex]$emptyRemarksPattern).Matches($content)
        
        # Remove all <value> tags
        $content = $content -replace $valuePattern, ''
        
        # Remove all empty <remarks> tags
        $content = $content -replace $emptyRemarksPattern, ''
        
        if ($content -ne $originalContent) {
            $valueCount = $valueMatches.Count
            $emptyRemarksCount = $emptyRemarksMatches.Count
            
            $totalValueTagsRemoved += $valueCount
            $totalEmptyRemarksRemoved += $emptyRemarksCount
            $filesModified++
            
            Set-Content -Path $file.FullName -Value $content -NoNewline
            
            $relativePath = $file.FullName.Replace($projectRoot, "").TrimStart('\')
            
            $changes = @()
            if ($valueCount -gt 0) { $changes += "$valueCount <value> tag(s)" }
            if ($emptyRemarksCount -gt 0) { $changes += "$emptyRemarksCount empty <remarks> tag(s)" }
            
            Write-Host "✓ $relativePath : Removed $($changes -join ', ')" -ForegroundColor Green
        }
    }
    catch {
        Write-Host "✗ Error processing $($file.FullName): $_" -ForegroundColor Red
    }
}

Write-Host ""
Write-Host "Summary:" -ForegroundColor Cyan
Write-Host "  Files processed: $($csFiles.Count)"
Write-Host "  Files modified: $filesModified"
Write-Host "  <value> tags removed: $totalValueTagsRemoved"
Write-Host "  Empty <remarks> tags removed: $totalEmptyRemarksRemoved"
Write-Host "  Total tags removed: $($totalValueTagsRemoved + $totalEmptyRemarksRemoved)"