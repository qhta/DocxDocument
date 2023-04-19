using DocumentModel.Vml;

namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Document Background.
/// </summary>
public class DocumentBackground: ModelElement
{
  /// <summary>
  ///   color
  /// </summary>
  public string? Color { get; set; }

  /// <summary>
  ///   themeColor
  /// </summary>
  public ThemeColorKind? ThemeColor { get; set; }

  /// <summary>
  ///   themeTint
  /// </summary>
  public string? ThemeTint { get; set; }

  /// <summary>
  ///   themeShade
  /// </summary>
  public string? ThemeShade { get; set; }

  /// <summary>
  ///   Background.
  /// </summary>
  public Background? Background { get; set; }
}