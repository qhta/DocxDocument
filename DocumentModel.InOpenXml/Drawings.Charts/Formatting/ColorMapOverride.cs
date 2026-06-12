namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a mechanism to override color assignments in a chart.
///   This class allows mapping specific theme colors (like Background1, Text1, Accents) to new color scheme indices.
/// </summary>
[OpenXmlType(typeof(DXDC.ColorMapOverride))]
[XmlRoot("ColorMapOverride", Namespace = "DocumentModel.Drawings.Charts")]
public partial class ColorMapOverride : ModelElement<DXDC.ColorMapOverride>
{
  /// <summary>
  ///   Override value for Background 1 color.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.ColorMapOverride.Background1))]
  public ColorSchemeIndex? Background1 { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  ///   Override value for Text 1 color.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.ColorMapOverride.Text1))]
  public ColorSchemeIndex? Text1 { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  ///   Override value for Background 2 color.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.ColorMapOverride.Background2))]
  public ColorSchemeIndex? Background2 { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  ///   Override value for Text 2 color.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.ColorMapOverride.Text2))]
  public ColorSchemeIndex? Text2 { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  ///   Override value for Accent 1 color.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.ColorMapOverride.Accent1))]
  public ColorSchemeIndex? Accent1 { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  ///   Override value for Accent 2 color.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.ColorMapOverride.Accent2))]
  public ColorSchemeIndex? Accent2 { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  ///   Override value for Accent 3 color.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.ColorMapOverride.Accent3))]
  public ColorSchemeIndex? Accent3 { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  ///   Override value for Accent 4 color.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.ColorMapOverride.Accent4))]
  public ColorSchemeIndex? Accent4 { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  ///   Override value for Accent 5 color.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.ColorMapOverride.Accent5))]
  public ColorSchemeIndex? Accent5 { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  ///   Override value for Accent 6 color.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.ColorMapOverride.Accent6))]
  public ColorSchemeIndex? Accent6 { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  ///   Override value for Hyperlink color.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.ColorMapOverride.Hyperlink))]
  public ColorSchemeIndex? Hyperlink { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  ///   Override value for Followed Hyperlink color.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.ColorMapOverride.FollowedHyperlink))]
  public ColorSchemeIndex? FollowedHyperlink { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  ///   Collection of extension elements for additional color map customization.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.ColorMapOverride.ExtensionList))]
  public ExtensionList? ExtensionList { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}