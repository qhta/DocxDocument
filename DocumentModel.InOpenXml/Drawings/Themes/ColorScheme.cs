namespace DocumentModel.Drawings;

/// <summary>
/// Defines the color scheme for drawing elements.
/// </summary>
[OpenXmlType(typeof(DXD.ColorScheme))]
public partial class ColorScheme: ModelElement<DXD.ColorScheme>, IOfficeArtExtendableElement
{
  /// <summary>
  /// The scheme name, which identifies the color scheme.
  /// This name is used to reference the color scheme within the document and can be used by applications to apply specific color schemes to drawing elements.
  /// The name should be unique within the context of the document's theme and is typically defined in the theme part of the document.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ColorScheme.Name))]
  public string? Name { get => _Name; set => UpdateField(ref _Name, value, nameof(Name)); }

  private string? _Name;

  /// <summary>
  /// <para>Dark 1.</para>
  /// <para>Represents the following element tag in the schema: a:dk1.</para>
  /// </summary>
  /// <remarks>
  /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
  /// </remarks>
  [OpenXmlProperty(nameof(DXD.ColorScheme.Dark1Color))]
  public ISchemeBaseColor? Dark1Color
  {
    get => _Dark1Color;
    set => UpdateField(ref _Dark1Color, value, nameof(Dark1Color));
  }

  private ISchemeBaseColor? _Dark1Color;

  /// <summary>
  /// <para>Light 1.</para>
  /// <para>Represents the following element tag in the schema: a:lt1.</para>
  /// </summary>
  /// <remarks>
  /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
  /// </remarks>
  [OpenXmlProperty(nameof(DXD.ColorScheme.Light1Color))]
  public ISchemeBaseColor? Light1Color
  {
    get => _Light1Color;
    set => UpdateField(ref _Light1Color, value, nameof(Light1Color));
  }

  private ISchemeBaseColor? _Light1Color;

  /// <summary>
  /// <para>Dark 2.</para>
  /// <para>Represents the following element tag in the schema: a:dk2.</para>
  /// </summary>
  /// <remarks>
  /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
  /// </remarks>
  [OpenXmlProperty(nameof(DXD.ColorScheme.Dark2Color))]
  public ISchemeBaseColor? Dark2Color
  {
    get => _Dark2Color;
    set => UpdateField(ref _Dark2Color, value, nameof(Dark2Color));
  }

  private ISchemeBaseColor? _Dark2Color;

  /// <summary>
  /// <para>Light 2.</para>
  /// <para>Represents the following element tag in the schema: a:lt2.</para>
  /// </summary>
  /// <remarks>
  /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
  /// </remarks>
  [OpenXmlProperty(nameof(DXD.ColorScheme.Light2Color))]
  public ISchemeBaseColor? Light2Color
  {
    get => _Light2Color;
    set => UpdateField(ref _Light2Color, value, nameof(Light2Color));
  }

  private ISchemeBaseColor? _Light2Color;

  /// <summary>
  /// <para>Accent 1.</para>
  /// <para>Represents the following element tag in the schema: a:accent1.</para>
  /// </summary>
  /// <remarks>
  /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
  /// </remarks>
  [OpenXmlProperty(nameof(DXD.ColorScheme.Accent1Color))]
  public ISchemeBaseColor? Accent1Color
  {
    get => _Accent1Color;
    set => UpdateField(ref _Accent1Color, value, nameof(Accent1Color));
  }

  private ISchemeBaseColor? _Accent1Color;

  /// <summary>
  /// <para>Accent 2.</para>
  /// <para>Represents the following element tag in the schema: a:accent2.</para>
  /// </summary>
  /// <remarks>
  /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
  /// </remarks>
  [OpenXmlProperty(nameof(DXD.ColorScheme.Accent2Color))]
  public ISchemeBaseColor? Accent2Color
  {
    get => _Accent2Color;
    set => UpdateField(ref _Accent2Color, value, nameof(Accent2Color));
  }

  private ISchemeBaseColor? _Accent2Color;

  /// <summary>
  /// <para>Accent 3.</para>
  /// <para>Represents the following element tag in the schema: a:accent3.</para>
  /// </summary>
  /// <remarks>
  /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
  /// </remarks>
  [OpenXmlProperty(nameof(DXD.ColorScheme.Accent3Color))]
  public ISchemeBaseColor? Accent3Color
  {
    get => _Accent3Color;
    set => UpdateField(ref _Accent3Color, value, nameof(Accent3Color));
  }

  private ISchemeBaseColor? _Accent3Color;

  /// <summary>
  /// <para>Accent 4.</para>
  /// <para>Represents the following element tag in the schema: a:accent4.</para>
  /// </summary>
  /// <remarks>
  /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
  /// </remarks>
  [OpenXmlProperty(nameof(DXD.ColorScheme.Accent4Color))]
  public ISchemeBaseColor? Accent4Color
  {
    get => _Accent4Color;
    set => UpdateField(ref _Accent4Color, value, nameof(Accent4Color));
  }

  private ISchemeBaseColor? _Accent4Color;

  /// <summary>
  /// <para>Accent 5.</para>
  /// <para>Represents the following element tag in the schema: a:accent5.</para>
  /// </summary>
  /// <remarks>
  /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
  /// </remarks>
  [OpenXmlProperty(nameof(DXD.ColorScheme.Accent5Color))]
  public ISchemeBaseColor? Accent5Color
  {
    get => _Accent5Color;
    set => UpdateField(ref _Accent5Color, value, nameof(Accent5Color));
  }

  private ISchemeBaseColor? _Accent5Color;

  /// <summary>
  /// <para>Accent 6.</para>
  /// <para>Represents the following element tag in the schema: a:accent6.</para>
  /// </summary>
  /// <remarks>
  /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
  /// </remarks>
  [OpenXmlProperty(nameof(DXD.ColorScheme.Accent6Color))]
  public ISchemeBaseColor? Accent6Color
  {
    get => _Accent6Color;
    set => UpdateField(ref _Accent6Color, value, nameof(Accent6Color));
  }

  private ISchemeBaseColor? _Accent6Color;

  /// <summary>
  /// <para>Hyperlink.</para>
  /// <para>Represents the following element tag in the schema: a:hlink.</para>
  /// </summary>
  /// <remarks>
  /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
  /// </remarks>
  [OpenXmlProperty(nameof(DXD.ColorScheme.Hyperlink))]
  public ISchemeBaseColor? Hyperlink
  {
    get => _Hyperlink;
    set => UpdateField(ref _Hyperlink, value, nameof(Hyperlink));
  }

  private ISchemeBaseColor? _Hyperlink;

  /// <summary>
  /// <para>Followed Hyperlink.</para>
  /// <para>Represents the following element tag in the schema: a:folHlink.</para>
  /// </summary>
  /// <remarks>
  /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
  /// </remarks>
  [OpenXmlProperty(nameof(DXD.ColorScheme.FollowedHyperlinkColor))]
  public ISchemeBaseColor? FollowedHyperlinkColor
  {
    get => _FollowedHyperlinkColor;
    set => UpdateField(ref _FollowedHyperlinkColor, value, nameof(FollowedHyperlinkColor));
  }

  private ISchemeBaseColor? _FollowedHyperlinkColor;

  /// <summary>
  /// ExtensionList, which allows for additional properties or elements to be associated with the color scheme.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ColorScheme.ExtensionList))]
  public OfficeArtExtensionList? OfficeArtExtensionList
  {
    get => _OfficeArtExtensionList;
    set => UpdateField(ref _OfficeArtExtensionList, value, nameof(ExtensionList));
  }

  private OfficeArtExtensionList? _OfficeArtExtensionList;

  /// <summary>
  /// Get a color from the color scheme based on the specified scheme color index.
  /// </summary>
  /// <param name="colorIndex">The scheme color index.</param>
  /// <returns>The corresponding color from the color scheme.</returns>
  /// <exception cref="ArgumentOutOfRangeException">Thrown when the color index is not supported.</exception>
  public ISchemeBaseColor? GetColor(SchemeColors colorIndex)
  {
    return colorIndex switch
    {
      SchemeColors.PhColor => null,
      SchemeColors.Dark1 => Dark1Color,
      SchemeColors.Light1 => Light1Color,
      SchemeColors.Dark2 => Dark2Color,
      SchemeColors.Light2 => Light2Color,
      SchemeColors.Accent1 => Accent1Color,
      SchemeColors.Accent2 => Accent2Color,
      SchemeColors.Accent3 => Accent3Color,
      SchemeColors.Accent4 => Accent4Color,
      SchemeColors.Accent5 => Accent5Color,
      SchemeColors.Accent6 => Accent6Color,
      SchemeColors.Hyperlink => Hyperlink,
      SchemeColors.FollowedHyperlink => FollowedHyperlinkColor,
      SchemeColors.Text1 => Dark1Color,
      SchemeColors.Background1 => Light1Color,
      SchemeColors.Text2 => Dark2Color,
      SchemeColors.Background2 => Light2Color,
      _ => throw new ArgumentOutOfRangeException(nameof(colorIndex), $"Unsupported color index: {colorIndex}")
    };
  }
}