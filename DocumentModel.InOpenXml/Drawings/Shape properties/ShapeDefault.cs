namespace DocumentModel.Drawings;
/// <summary>
///   Represents default shape properties, including shape, body, list, and style settings.
/// </summary>
public partial class ShapeDefault : ModelElement<DXD.ShapeDefault>, IExtendableElement
{
    /// <summary>
    ///   Default shape properties.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ShapeDefault.ShapeProperties))]
    /// <summary>
    ///   Default shape properties.
    /// </summary>
    [OpenXmlElement(typeof(DXD.ShapeDefault))]
    public ShapeProperties? ShapeProperties { get => _ShapeProperties; set => UpdateField(ref _ShapeProperties, value, nameof(ShapeProperties)); }

    private ShapeProperties? _ShapeProperties;
    /// <summary>
    ///   Default body properties for the shape.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ShapeDefault.BodyProperties))]
    /// <summary>
    ///   Default body properties for the shape.
    /// </summary>
    [OpenXmlElement(typeof(DXD.ShapeDefault))]
    public BodyProperties? BodyProperties { get => _BodyProperties; set => UpdateField(ref _BodyProperties, value, nameof(BodyProperties)); }

    private BodyProperties? _BodyProperties;
    /// <summary>
    ///   Default list style for the shape.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ShapeDefault.ListStyle))]
    /// <summary>
    ///   Default list style for the shape.
    /// </summary>
    [OpenXmlElement(typeof(DXD.ShapeDefault))]
    public ListStyle? ListStyle { get => _ListStyle; set => UpdateField(ref _ListStyle, value, nameof(ListStyle)); }

    private ListStyle? _ListStyle;
    /// <summary>
    ///   Default shape style.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ShapeDefault.ShapeStyle))]
    /// <summary>
    ///   Default shape style.
    /// </summary>
    [OpenXmlElement(typeof(DXD.ShapeDefault))]
    public ShapeStyle? ShapeStyle { get => _ShapeStyle; set => UpdateField(ref _ShapeStyle, value, nameof(ShapeStyle)); }

    private ShapeStyle? _ShapeStyle;
    /// <summary>
    /// List of extension elements.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ShapeDefault.ExtensionList))]
    /// <summary>
    /// List of extension elements.
    /// </summary>
    [OpenXmlElement(typeof(DXD.ShapeDefault))]
    public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

    private ExtensionList? _ExtensionList;
}