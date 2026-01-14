namespace DocumentModel.Drawings;

/// <summary>
/// Defines the color scheme for drawing elements.
/// </summary>
public partial interface ColorScheme: IExtendableElement
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
  public ColorType? Dark1Color { get; set; }

  /// <summary>
  /// Light 1.
  /// </summary>
  [XmlIgnore]
  public ColorType? Light1Color { get; set; }

  /// <summary>
  /// Dark 2.
  /// </summary>
  [XmlIgnore]
  public ColorType? Dark2Color { get; set; }

  /// <summary>
  /// Light 2.
  /// </summary>
  [XmlIgnore]
  public ColorType? Light2Color { get; set; }

  /// <summary>
  /// Accent 1.
  /// </summary>
  [XmlIgnore]
  public ColorType? Accent1Color { get; set; }

  /// <summary>
  /// Accent 2.
  /// </summary>
  [XmlIgnore]
  public ColorType? Accent2Color { get; set; }

  /// <summary>
  /// Accent 3.
  /// </summary>
  [XmlIgnore]
  public ColorType? Accent3Color { get; set; }

  /// <summary>
  /// Accent 4.
  /// </summary>
  [XmlIgnore]
  public ColorType? Accent4Color { get; set; }

  /// <summary>
  /// Accent 5.
  /// </summary>
  [XmlIgnore]
  public ColorType? Accent5Color { get; set; }

  /// <summary>
  /// Accent 6.
  /// </summary>
  [XmlIgnore]
  public ColorType? Accent6Color { get; set; }

  /// <summary>
  /// Hyperlink.
  /// </summary>
  [XmlIgnore]
  public ColorType? Hyperlink { get; set; }

  /// <summary>
  /// Followed hyperlink.
  /// </summary>
  [XmlIgnore]
  public ColorType? FollowedHyperlinkColor { get; set; }
  #endregion

  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}