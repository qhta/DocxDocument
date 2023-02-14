namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ColorScheme Class.
/// </summary>
public class ColorScheme
{
  /// <summary>
  ///   Name
  /// </summary>
  public String? Name { get; set; }

  /// <summary>
  ///   Dark 1.
  /// </summary>
  public Color2Type? Dark1Color { get; set; }

  /// <summary>
  ///   Light 1.
  /// </summary>
  public Color2Type? Light1Color { get; set; }

  /// <summary>
  ///   Dark 2.
  /// </summary>
  public Color2Type? Dark2Color { get; set; }

  /// <summary>
  ///   Light 2.
  /// </summary>
  public Color2Type? Light2Color { get; set; }

  /// <summary>
  ///   Accent 1.
  /// </summary>
  public Color2Type? Accent1Color { get; set; }

  /// <summary>
  ///   Accent 2.
  /// </summary>
  public Color2Type? Accent2Color { get; set; }

  /// <summary>
  ///   Accent 3.
  /// </summary>
  public Color2Type? Accent3Color { get; set; }

  /// <summary>
  ///   Accent 4.
  /// </summary>
  public Color2Type? Accent4Color { get; set; }

  /// <summary>
  ///   Accent 5.
  /// </summary>
  public Color2Type? Accent5Color { get; set; }

  /// <summary>
  ///   Accent 6.
  /// </summary>
  public Color2Type? Accent6Color { get; set; }

  /// <summary>
  ///   Hyperlink.
  /// </summary>
  public Color2Type? Hyperlink { get; set; }

  /// <summary>
  ///   Followed Hyperlink.
  /// </summary>
  public Color2Type? FollowedHyperlinkColor { get; set; }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}