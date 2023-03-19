using DocumentModel.Vml;

namespace DocumentModel.Wordprocessing;

/// <summary>
///   Document Background.
/// </summary>
public class DocumentBackground: ModelElement
{
  /// <summary>
  ///   color
  /// </summary>
  public String? Color { get; set; }

  /// <summary>
  ///   themeColor
  /// </summary>
  public ThemeColorKind? ThemeColor { get; set; }

  /// <summary>
  ///   themeTint
  /// </summary>
  public String? ThemeTint { get; set; }

  /// <summary>
  ///   themeShade
  /// </summary>
  public String? ThemeShade { get; set; }

  /// <summary>
  ///   Background.
  /// </summary>
  public Background? Background { get; set; }
}