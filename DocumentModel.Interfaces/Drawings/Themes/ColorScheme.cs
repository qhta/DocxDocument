namespace DocumentModel.Drawings;

/// <summary>
/// Defines the color scheme for drawing elements.
/// </summary>
public partial interface ColorScheme: ExtendableElement
{
  /// <summary>
  /// Name.
  /// </summary>
  public string? Name { get; set; }

  #region specific color definitions
  /// <summary>
  /// Dark 1.
  /// </summary>
  [XmlIgnore]
  public Color2Type? Dark1Color { get; set; }

  /// <summary>
  /// Light 1.
  /// </summary>
  [XmlIgnore]
  public Color2Type? Light1Color { get; set; }

  /// <summary>
  /// Dark 2.
  /// </summary>
  [XmlIgnore]
  public Color2Type? Dark2Color { get; set; }

  /// <summary>
  /// Light 2.
  /// </summary>
  [XmlIgnore]
  public Color2Type? Light2Color { get; set; }

  /// <summary>
  /// Accent 1.
  /// </summary>
  [XmlIgnore]
  public Color2Type? Accent1Color { get; set; }

  /// <summary>
  /// Accent 2.
  /// </summary>
  [XmlIgnore]
  public Color2Type? Accent2Color { get; set; }

  /// <summary>
  /// Accent 3.
  /// </summary>
  [XmlIgnore]
  public Color2Type? Accent3Color { get; set; }

  /// <summary>
  /// Accent 4.
  /// </summary>
  [XmlIgnore]
  public Color2Type? Accent4Color { get; set; }

  /// <summary>
  /// Accent 5.
  /// </summary>
  [XmlIgnore]
  public Color2Type? Accent5Color { get; set; }

  /// <summary>
  /// Accent 6.
  /// </summary>
  [XmlIgnore]
  public Color2Type? Accent6Color { get; set; }

  /// <summary>
  /// Hyperlink.
  /// </summary>
  [XmlIgnore]
  public Color2Type? Hyperlink { get; set; }

  /// <summary>
  /// Followed hyperlink.
  /// </summary>
  [XmlIgnore]
  public Color2Type? FollowedHyperlinkColor { get; set; }
  #endregion

  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}