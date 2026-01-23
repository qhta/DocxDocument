using DocumentModel.Drawings.Colors;

namespace DocumentModel.Drawings;
/// <summary>
/// Defines the color scheme for drawing elements.
/// </summary>
[OpenXmlType(typeof(DXD.ColorScheme))]
/// <summary>
/// Defines the color scheme for drawing elements.
/// </summary>
public partial class ColorScheme : ModelElement<DXD.ColorScheme>, IExtendableElement
{
  /// <summary>
  /// Name.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ColorScheme.Name))]
  public string? Name { get => _Name; set => UpdateField(ref _Name, value, nameof(Name)); }

  private string? _Name;
  /// <summary>
  /// Dark 1.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ColorScheme.Dark1Color))]
  #region specific color definitions
  public IDrawingColor? Dark1Color { get; set; }

  /// <summary>
  /// Light 1.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ColorScheme.Light1Color))]
  public IDrawingColor? Light1Color { get; set; }

  /// <summary>
  /// Dark 2.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ColorScheme.Dark2Color))]
  public IDrawingColor? Dark2Color { get; set; }

  /// <summary>
  /// Light 2.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ColorScheme.Light2Color))]
  public IDrawingColor? Light2Color { get; set; }

  /// <summary>
  /// Accent 1.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ColorScheme.Accent1Color))]
  public IDrawingColor? Accent1Color { get; set; }

  /// <summary>
  /// Accent 2.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ColorScheme.Accent2Color))]
  public IDrawingColor? Accent2Color { get; set; }

  /// <summary>
  /// Accent 3.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ColorScheme.Accent3Color))]
  public IDrawingColor? Accent3Color { get; set; }

  /// <summary>
  /// Accent 4.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ColorScheme.Accent4Color))]
  public IDrawingColor? Accent4Color { get; set; }

  /// <summary>
  /// Accent 5.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ColorScheme.Accent5Color))]
  public IDrawingColor? Accent5Color { get; set; }

  /// <summary>
  /// Accent 6.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ColorScheme.Accent6Color))]
  public IDrawingColor? Accent6Color { get; set; }

  /// <summary>
  /// Hyperlink.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ColorScheme.Hyperlink))]
  public IDrawingColor? Hyperlink { get; set; }

  /// <summary>
  /// Followed hyperlink.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ColorScheme.FollowedHyperlinkColor))]
  public IDrawingColor? FollowedHyperlinkColor { get; set; }

  /// <summary>
  /// List of extensions associated with this object.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ColorScheme.ExtensionList))]
  #endregion

  /// <summary>
  /// List of extensions associated with this object.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }

  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  [OpenXmlElement(typeof(DXOD.OfficeArtExtensionList))]
  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}