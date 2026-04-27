using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Wordprocessing;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using Qhta.Collections;

namespace AutoEdit;

/// <summary>
/// Provides helper methods for discovering namespace aliases in individual source files and project-wide global usings.
/// </summary>
static class AliasHelper
{
  private static readonly Dictionary<string, Type?> _typeCache = new(StringComparer.Ordinal);
  public static readonly Assembly? OpenXmlFrameworkAssembly = typeof(OpenXmlElement).Assembly;
  public static readonly Assembly? OpenXmlAssembly = typeof(Document).Assembly;

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

    var globalAliases = FindGlobalAliases(filePath);
    if (globalAliases != null)
      foreach (var kvp in globalAliases)
      {
        if (!map.ContainsKey(kvp.Key))
          map[kvp.Key] = kvp.Value;
      }

    return map;
  }

  /// <summary>
  /// Retrieves project-level alias mappings defined in <c>GlobalUsings.cs</c> if present.
  /// </summary>
  private static Dictionary<string, string>? FindGlobalAliases(string filePath)
  {

    var projectDir = FindProjectRoot(Path.GetDirectoryName(filePath)!);
    if (projectDir == null)
      return null;

    var map = new Dictionary<string, string>();
    var globalUsingsPath = Path.Combine(projectDir, "GlobalUsings.cs");
    if (File.Exists(globalUsingsPath))
    {
      var globalAliases = GetGlobalUsings(filePath);
      foreach (var kvp in globalAliases)
      {
        if (!map.ContainsKey(kvp.Key))
          map[kvp.Key] = kvp.Value;
      }
    }
    var projectFiles = Directory.GetFiles(projectDir, "*.csproj");
    foreach (var file in projectFiles)
    {
      var linkedFiles = GetLinkedFiles(file);
      foreach (var linkedFile in linkedFiles)
      {
        var globalAliases = GetGlobalUsings(linkedFile);
        foreach (var kvp in globalAliases)
        {
          if (!map.ContainsKey(kvp.Key))
            map[kvp.Key] = kvp.Value;
        }
      }
    }

    return map;
  }

  /// <summary>
  /// Get files linked in the project file with a <c>include</c> attribute, which may include the <c>GlobalUsings.cs</c> file containing project-wide alias definitions.
  /// </summary>
  /// <param name="projectFilePath"></param>
  /// <returns></returns>
  private static List<string> GetLinkedFiles(string projectFilePath)
  {
    var result = new List<string>();
    if (!File.Exists(projectFilePath))
      return result;

    var projectDir = Path.GetDirectoryName(projectFilePath) ?? string.Empty;
    var regex = new Regex("<Compile\\s+Include=\"(?<include>[^\"]+)\"\\s+Link=\"(?<link>[^\"]+)\"\\s*/>",
      RegexOptions.Compiled);

    foreach (var line in File.ReadLines(projectFilePath))
    {
      var match = regex.Match(line);
      if (!match.Success)
        continue;

      var includePath = match.Groups["include"].Value;
      if (string.IsNullOrWhiteSpace(includePath))
        continue;

      var fullPath = Path.GetFullPath(Path.Combine(projectDir, includePath));
      result.Add(fullPath);
    }

    return result;
  }


  /// <summary>
  /// Gets alias mappings from a *.cs file by parsing lines that match the pattern of global using alias directives.
  /// </summary>
  /// <param name="sourceFilePath">A path to file containing global usings directives</param>
  /// <returns>A dictionary mapping alias identifiers to fully-qualified namespaces.</returns>
  private static Dictionary<string, string> GetGlobalUsings(string sourceFilePath)
  {
    var map = new Dictionary<string, string>(StringComparer.Ordinal);

    foreach (var line in File.ReadLines(sourceFilePath))
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
  }

  /// <summary>
  /// Finds the nearest ancestor directory that contains a <c>.csproj</c> file.
  /// </summary>
  /// <param name="startDir">Directory used as the starting point for the search.</param>
  /// <returns>The project root directory, or <see langword="null"/> when not found.</returns>
  private static string? FindProjectRoot(string startDir)
  {
    var current = startDir;
    if (!string.IsNullOrEmpty(current))
    {
      if (Directory.GetFiles(current, "*.csproj").Any())
        return current;

      var parent = Path.GetDirectoryName(current);
      if (parent != null)
        return FindProjectRoot(parent);

    }
    return null;
  }

  /// <summary>
  /// Expands namespace aliases referenced within the current file.
  /// </summary>
  /// <param name="typeName">Type name potentially prefixed with an alias.</param>
  /// <param name="aliasMap">A bidirectional dictionary mapping aliases to namespaces.</param>
  public static string ResolveAlias(this BiDiDictionary<string, string> aliasMap, string typeName)
  {
    var dotIndex = typeName.IndexOf('.');
    if (dotIndex > 0)
    {
      var alias = typeName.Substring(0, dotIndex);
      if (aliasMap.TryGetValue(alias, out var ns))
        return ns + "." + typeName.Substring(dotIndex + 1);
    }
    return typeName;
  }

  /// <summary>
  /// Gets namespace alias for the type name.
  /// </summary>
  /// <param name="typeName">Type name that may use an alias prefix.</param>
  /// <param name="aliasMap">A bidirectional dictionary mapping aliases to namespaces.</param>
  /// <returns>Aliased type name.</returns>
  public static string? GetAlias(this BiDiDictionary<string, string> aliasMap, string typeName)
  {
    var dotIndex = typeName.LastIndexOf('.');
    if (dotIndex > 0)
    {
      var ns = typeName.Substring(0, dotIndex);
      if (aliasMap.TryGetValue1(ns, out var alias))
        return alias;
    }
    return null;
  }

  /// <summary>
  /// Resolves namespace alias in the provided type name..
  /// </summary>
  /// <param name="typeName">Type name that may use an alias prefix.</param>
  /// <param name="aliasMap">A bidirectional dictionary mapping aliases to namespaces.</param>
  /// <returns>The fully-qualified type name.</returns>
  public static string ResolveNsAlias(this BiDiDictionary<string, string> aliasMap, string typeName)
  {
    var dotIndex = typeName.LastIndexOf('.');
    if (dotIndex > 0)
    {
      var alias = typeName.Substring(0, dotIndex);
      if (aliasMap.TryGetValue2(alias, out var ns))
        return ns + "." + typeName.Substring(dotIndex + 1);
    }
    return typeName;
  }

  /// <summary>
  /// Attempts to resolve a type using alias expansion and loaded assemblies.
  /// </summary>
  /// <param name="typeName">Candidate type name, possibly using an alias.</param>
  /// <param name="type">Resolved <see cref="Type"/> when successful.</param>
  /// <param name="aliasMap">A bidirectional dictionary mapping aliases to namespaces.</param>
  /// <returns><see langword="true"/> if the type is resolved; otherwise <see langword="false"/>.</returns>
  public static bool TryResolveOpenXmlType(this BiDiDictionary<string, string> aliasMap, string typeName, out Type? type)
  {
    if (_typeCache.TryGetValue(typeName, out var cached))
    {
      type = cached!;
      return cached != null;
    }
    var resolvedName = aliasMap.ResolveNsAlias(typeName);
    type = Type.GetType(resolvedName, throwOnError: false, ignoreCase: false) ??
           OpenXmlFrameworkAssembly?.GetType(resolvedName, throwOnError: false, ignoreCase: false) ??
           OpenXmlAssembly?.GetType(resolvedName, throwOnError: false, ignoreCase: false);
    if (type == null)
    {
      var assembliesToSearch = AppDomain.CurrentDomain.GetAssemblies().ToList();
      foreach (var asm in assembliesToSearch)
      {
        type = asm.GetType(resolvedName, false, false);
        if (type != null)
          break;
      }
    }
    _typeCache[typeName] = type;
    return type != null;
  }
}


