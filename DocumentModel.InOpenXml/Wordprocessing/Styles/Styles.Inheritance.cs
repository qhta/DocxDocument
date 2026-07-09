using System.Linq;

namespace DocumentModel.Wordprocessing;

/// <summary>
/// Helpers for resolving effective style properties from doc defaults + basedOn chain.
/// </summary>
public sealed partial class Styles
{
  /// <summary>
  /// Finds a style definition by style id (case-insensitive).
  /// </summary>
  public Style? FindStyleDefinition(string? styleId)
  {
    if (string.IsNullOrWhiteSpace(styleId))
      return null;

    return StyleDefinitions.FirstOrDefault(s =>
      string.Equals(s.StyleId, styleId, StringComparison.OrdinalIgnoreCase));
  }

  /// <summary>
  /// Gets style inheritance chain in root-to-leaf order.
  /// </summary>
  public IReadOnlyList<Style> GetStyleInheritanceChain(string? styleId)
  {
    var chain = new List<Style>();
    var visited = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

    var current = FindStyleDefinition(styleId);
    while (current != null)
    {
      var id = current.StyleId ?? string.Empty;
      if (!visited.Add(id))
        break; // cycle protection

      chain.Add(current);

      if (string.IsNullOrWhiteSpace(current.BasedOn))
        break;

      current = FindStyleDefinition(current.BasedOn);
    }

    chain.Reverse(); // base first, target last
    return chain;
  }

  /// <summary>
  /// Resolves effective paragraph properties for a style id.
  /// </summary>
  public ParagraphProperties GetEffectiveParagraphProperties(string? styleId)
  {
    var result = new ParagraphProperties();

    // 1) doc defaults
    if (DocDefaults?.DefaultParagraphProperties is not null)
      result.CopyFrom(DocDefaults.DefaultParagraphProperties);

    // 2) basedOn chain + current style
    foreach (var style in GetStyleInheritanceChain(styleId))
    {
      var styleParagraphProperties = GetPropertyValue(style,
        "StyleParagraphProperties",
        "ParagraphProperties",
        "ParagraphPropertiesBaseStyle");

      MergeFrom(result, styleParagraphProperties);
    }

    return result;
  }

  /// <summary>
  /// Resolves effective run properties for a style id.
  /// </summary>
  public RunProperties GetEffectiveRunProperties(string? styleId)
  {
    var result = new RunProperties();

    // 1) doc defaults
    if (DocDefaults?.DefaultRunProperties is not null)
      result.CopyFrom(DocDefaults.DefaultRunProperties);

    // 2) basedOn chain + current style
    foreach (var style in GetStyleInheritanceChain(styleId))
    {
      var styleRunProperties = GetPropertyValue(style,
        "StyleRunProperties",
        "RunProperties",
        "RunPropertiesBaseStyle");

      MergeFrom(result, styleRunProperties);
    }

    return result;
  }

  private static void MergeFrom(ModelElement target, object? source)
  {
    if (source is ModelElement sourceElement)
      target.CopyFrom(sourceElement);
  }

  private static object? GetPropertyValue(object source, params string[] propertyNames)
  {
    var type = source.GetType();
    foreach (var name in propertyNames)
    {
      var prop = type.GetProperty(name, BindingFlags.Public | BindingFlags.Instance);
      if (prop != null)
      {
        var value = prop.GetValue(source);
        if (value != null)
          return value;
      }
    }

    return null;
  }
}