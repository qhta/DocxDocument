namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ColorScheme interface.
/// </summary>
public partial interface ColorScheme
{
  /// <summary>
  ///   Name
  /// </summary>
  public string? Name { get; set; }
  public ThemeColors ThemeColors { get; set; }
  #region specific color definitions
  /// <summary>
  ///   Dark 1.
  /// </summary>
  [XmlIgnore]
  public ThemeColor? Dark1Color { get; set; }

  /// <summary>
  ///   Light 1.
  /// </summary>
  [XmlIgnore]
  public ThemeColor? Light1Color { get; set; }
  /// <summary>
  ///   Dark 2.
  /// </summary>
  [XmlIgnore]
  public ThemeColor? Dark2Color { get; set; }
  /// <summary>
  ///   Light 2.
  /// </summary>
  [XmlIgnore]
  public ThemeColor? Light2Color { get; set; }
    /// <summary>
  ///   Accent 1.
  /// </summary>
  [XmlIgnore]
  public ThemeColor? Accent1Color { get; set; }
  /// <summary>
  ///   Accent 2.
  /// </summary>
  [XmlIgnore]
  public ThemeColor? Accent2Color { get; set; }   

  /// <summary>
  ///   Accent 3.
  /// </summary>
  [XmlIgnore]
  public ThemeColor? Accent3Color { get; set; }
  /// <summary>
  ///   Accent 4.
  /// </summary>
  [XmlIgnore]
  public ThemeColor? Accent4Color { get; set; }
  /// <summary>
  ///   Accent 5.
  /// </summary>
  [XmlIgnore]
  public ThemeColor? Accent5Color { get; set; }
  /// <summary>
  ///   Accent 6.
  /// </summary>
  [XmlIgnore]
  public ThemeColor? Accent6Color { get; set; }
  /// <summary>
  ///   IHyperlink.
  /// </summary>
  [XmlIgnore]
  public ThemeColor? Hyperlink { get; set; }
  /// <summary>
  ///   Followed IHyperlink.
  /// </summary>
  [XmlIgnore]
  public ThemeColor? FollowedHyperlinkColor { get; set; }
  #endregion
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}