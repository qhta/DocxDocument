using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using Qhta.Collections;

namespace AutoEdit;

/// <summary>
/// Provides helper methods for discovering namespace aliases in individual source files and project-wide global usings.
/// </summary>
static class AliasHelper
{
  private static readonly ConcurrentDictionary<string, Dictionary<string, string>> GlobalAliasCache = new(StringComparer.OrdinalIgnoreCase);

  /// <summary>
  /// Builds an alias map from local <c>using</c> directives and cached global aliases for the containing project.
  /// </summary>
  /// <param name="filePath">Path to the source file currently being processed.</param>
  /// <param name="root">The parsed compilation unit for the file.</param>
  /// <returns>A dictionary mapping alias identifiers to fully-qualified namespaces.</returns>
  public static BiDiDictionary<string, string> BuildAliasMap(string filePath, CompilationUnitSyntax root)
  {
    var map = new BiDiDictionary<string, string>(StringComparer.Ordinal, StringComparer.Ordinal);

    foreach (var u in root.Usings.Where(u => u.Alias != null))
    {
      if (u.Name != null)
        map[u.Alias!.Name.Identifier.Text] = u.Name.ToString();
    }

    foreach (var kvp in GetGlobalAliases(filePath))
    {
      if (!map.ContainsKey(kvp.Key))
        map[kvp.Key] = kvp.Value;
    }

    return map;
  }

  /// <summary>
  /// Retrieves project-level alias mappings defined in <c>GlobalUsings.cs</c> if present.
  /// </summary>
  private static Dictionary<string, string> GetGlobalAliases(string filePath)
  {
    var projectDir = FindProjectRoot(Path.GetDirectoryName(filePath)!);
    if (projectDir == null)
      return new Dictionary<string, string>(StringComparer.Ordinal);

    return GlobalAliasCache.GetOrAdd(projectDir, dir =>
    {
      var map = new Dictionary<string, string>(StringComparer.Ordinal);
      var globalUsingsPath = Path.Combine(dir, "GlobalUsings.cs");
      if (!File.Exists(globalUsingsPath))
        return map;

      foreach (var line in File.ReadLines(globalUsingsPath))
      {
        var trimmed = line.Trim();
        if (!trimmed.StartsWith("global using", StringComparison.Ordinal) || !trimmed.Contains('='))
          continue;

        var eqIndex = trimmed.IndexOf('=');
        var aliasPart = trimmed.Substring("global using".Length, eqIndex - "global using".Length).Trim();
        var nsPart = trimmed.Substring(eqIndex + 1).Trim().TrimEnd(';');

        if (!string.IsNullOrEmpty(aliasPart) && !string.IsNullOrEmpty(nsPart))
          map[aliasPart] = nsPart;
      }
      return map;
    });
  }

  /// <summary>
  /// Finds the nearest ancestor directory that contains a <c>.csproj</c> file.
  /// </summary>
  /// <param name="startDir">Directory used as the starting point for the search.</param>
  /// <returns>The project root directory, or <see langword="null"/> when not found.</returns>
  private static string? FindProjectRoot(string startDir)
  {
    var current = startDir;
    while (!string.IsNullOrEmpty(current))
    {
      if (Directory.GetFiles(current, "*.csproj").Any())
        return current;

      var parent = Directory.GetParent(current);
      if (parent == null)
        break;

      current = parent.FullName;
    }
    return null;
  }
}

