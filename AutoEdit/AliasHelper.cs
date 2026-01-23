using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace AutoEdit;

static class AliasHelper
{
  private static readonly ConcurrentDictionary<string, Dictionary<string, string>> GlobalAliasCache = new(StringComparer.OrdinalIgnoreCase);

  public static Dictionary<string, string> BuildAliasMap(string filePath, CompilationUnitSyntax root)
  {
    var map = new Dictionary<string, string>(StringComparer.Ordinal);

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

