namespace DocumentModel.Drawings;

/// <summary>
///   Represents the main elements of a theme, including color scheme, font scheme, and format scheme.
/// </summary>
[OpenXmlType(typeof(DXD.ThemeElements))]
[DataContract]
[XmlRoot("ThemeElements", Namespace = "DocumentModel.Drawings")]
public partial class ThemeElements: ModelElement<DXD.ThemeElements>, IExtendableElement
{
  ///// <summary>
  ///// Default constructor needed for XmlSerializer.
  ///// </summary>
  //public ThemeElements() { }

  ///// <summary>
  ///// Parent initializing constructor needed for CopyFrom operation.
  ///// </summary>
  ///// <param name="parent">The parent model element.</param>
  //public ThemeElements(ModelElement parent): base(parent) { }

  /// <summary>
  ///   Color scheme for the theme.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ThemeElements.ColorScheme))]
  public ColorScheme? ColorScheme
  {
    get => _ColorScheme ??= GetProperty<ColorScheme?>(GetUpdatableElement()?.ColorScheme);
    set => UpdateField(ref _ColorScheme, value, nameof(ColorScheme));
  }

  private ColorScheme? _ColorScheme;

  /// <summary>
  ///   TextFormat scheme for the theme.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ThemeElements.FontScheme))]
  public FontScheme? FontScheme
  {
    get => _FontScheme ??= GetProperty<FontScheme?>(GetUpdatableElement()?.FontScheme);
    set => UpdateField(ref _FontScheme, value, nameof(FontScheme));
  }

  private FontScheme? _FontScheme;

  /// <summary>
  ///   Format scheme for the theme.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ThemeElements.FormatScheme))]
  public FormatScheme? FormatScheme
  {
    get => _FormatScheme ??= GetProperty<FormatScheme?>(GetUpdatableElement()?.FormatScheme);
    set => UpdateField(ref _FormatScheme, value, nameof(FormatScheme));
  }

  private FormatScheme? _FormatScheme;

  /// <summary>
  /// List of extensions for the theme elements.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ThemeElements.ExtensionList))]
  public ExtensionList? ExtensionList
  {
    get => _ExtensionList ??= GetProperty<ExtensionList?>(GetUpdatableElement()?.ExtensionList);
    set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList));
  }

  private ExtensionList? _ExtensionList;
}