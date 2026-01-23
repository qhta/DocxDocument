namespace DocumentModel.Drawings;
/// <summary>
///   Represents default text properties for a shape, including shape, body, list, and style settings.
/// </summary>
public partial class TextDefault : ModelElement<DXD.TextDefault>, IExtendableElement
{
    /// <summary>
    ///   Default shape properties for text.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.TextDefault.ShapeProperties))]
    /// <summary>
    ///   Default shape properties for text.
    /// </summary>
    [OpenXmlElement(typeof(DXD.TextDefault))]
    public ShapeProperties? ShapeProperties { get => _ShapeProperties; set => UpdateField(ref _ShapeProperties, value, nameof(ShapeProperties)); }

    private ShapeProperties? _ShapeProperties;
    /// <summary>
    ///   Default body properties for text.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.TextDefault.BodyProperties))]
    /// <summary>
    ///   Default body properties for text.
    /// </summary>
    [OpenXmlElement(typeof(DXD.TextDefault))]
    public BodyProperties? BodyProperties { get => _BodyProperties; set => UpdateField(ref _BodyProperties, value, nameof(BodyProperties)); }

    private BodyProperties? _BodyProperties;
    /// <summary>
    ///   Default list style for text.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.TextDefault.ListStyle))]
    /// <summary>
    ///   Default list style for text.
    /// </summary>
    [OpenXmlElement(typeof(DXD.TextDefault))]
    public ListStyle? ListStyle { get => _ListStyle; set => UpdateField(ref _ListStyle, value, nameof(ListStyle)); }

    private ListStyle? _ListStyle;
    /// <summary>
    ///   Default shape style for text.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.TextDefault.ShapeStyle))]
    /// <summary>
    ///   Default shape style for text.
    /// </summary>
    [OpenXmlElement(typeof(DXD.TextDefault))]
    public ShapeStyle? ShapeStyle { get => _ShapeStyle; set => UpdateField(ref _ShapeStyle, value, nameof(ShapeStyle)); }

    private ShapeStyle? _ShapeStyle;
    /// <summary>
    /// List of extension properties for the text default, used for extensibility scenarios.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.TextDefault.ExtensionList))]
    /// <summary>
    /// List of extension properties for the text default, used for extensibility scenarios.
    /// </summary>
    [OpenXmlElement(typeof(DXD.TextDefault))]
    public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

    private ExtensionList? _ExtensionList;
}