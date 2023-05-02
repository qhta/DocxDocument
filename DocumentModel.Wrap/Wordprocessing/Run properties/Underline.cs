namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Underline Class.
/// </summary>
public class Underline: ModelElement
{
  /// <summary>
  ///   Underline Style
  /// </summary>
  public UnderlineKind? Type { get; set; }

  /// <summary>
  ///   Underline Color
  /// </summary>
  public string? Color { get; set; }

  /// <summary>
  ///   Underline Theme Color
  /// </summary>
  public ThemeColorKind? ThemeColor { get; set; }

  /// <summary>
  ///   Underline Theme Color Tint
  /// </summary>
  public string? ThemeTint { get; set; }

  /// <summary>
  ///   Underline Theme Color Shade
  /// </summary>
  public string? ThemeShade { get; set; }
}