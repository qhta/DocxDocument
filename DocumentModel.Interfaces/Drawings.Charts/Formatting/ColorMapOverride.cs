namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a mechanism to override color assignments in a chart.
///   This interface allows mapping specific theme colors (like Background1, Text1, Accents) to new color scheme indices.
/// </summary>
public interface ColorMapOverride
{
  /// <summary>
  ///   Override value for Background 1 color.
  /// </summary>
  public ColorSchemeIndexKind? Background1 { get; set; }

  /// <summary>
  ///   Override value for Text 1 color.
  /// </summary>
  public ColorSchemeIndexKind? Text1 { get; set; }

  /// <summary>
  ///   Override value for Background 2 color.
  /// </summary>
  public ColorSchemeIndexKind? Background2 { get; set; }

  /// <summary>
  ///   Override value for Text 2 color.
  /// </summary>
  public ColorSchemeIndexKind? Text2 { get; set; }

  /// <summary>
  ///   Override value for Accent 1 color.
  /// </summary>
  public ColorSchemeIndexKind? Accent1 { get; set; }

  /// <summary>
  ///   Override value for Accent 2 color.
  /// </summary>
  public ColorSchemeIndexKind? Accent2 { get; set; }

  /// <summary>
  ///   Override value for Accent 3 color.
  /// </summary>
  public ColorSchemeIndexKind? Accent3 { get; set; }

  /// <summary>
  ///   Override value for Accent 4 color.
  /// </summary>
  public ColorSchemeIndexKind? Accent4 { get; set; }

  /// <summary>
  ///   Override value for Accent 5 color.
  /// </summary>
  public ColorSchemeIndexKind? Accent5 { get; set; }

  /// <summary>
  ///   Override value for Accent 6 color.
  /// </summary>
  public ColorSchemeIndexKind? Accent6 { get; set; }

  /// <summary>
  ///   Override value for Hyperlink color.
  /// </summary>
  public ColorSchemeIndexKind? Hyperlink { get; set; }

  /// <summary>
  ///   Override value for Followed Hyperlink color.
  /// </summary>
  public ColorSchemeIndexKind? FollowedHyperlink { get; set; }

  /// <summary>
  ///   Collection of extension elements for additional color map customization.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}