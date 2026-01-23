namespace DocumentModel.Drawings;
/// <summary>
///   Represents default line properties, including shape, body, list, and style settings.
/// </summary>
public partial class LineDefault : ModelElement<DXD.LineDefault>, IExtendableElement
{
    /// <summary>
    ///   Default shape properties for the line.
    /// </summary>
    public ShapeProperties? ShapeProperties { get => _ShapeProperties; set => UpdateField(ref _ShapeProperties, value, nameof(ShapeProperties)); }

    private ShapeProperties? _ShapeProperties;
    /// <summary>
    ///   Default body properties for the line.
    /// </summary>
    public BodyProperties? BodyProperties { get => _BodyProperties; set => UpdateField(ref _BodyProperties, value, nameof(BodyProperties)); }

    private BodyProperties? _BodyProperties;
    /// <summary>
    ///   Default list style for the line.
    /// </summary>
    public ListStyle? ListStyle { get => _ListStyle; set => UpdateField(ref _ListStyle, value, nameof(ListStyle)); }

    private ListStyle? _ListStyle;
    /// <summary>
    ///   Default shape style for the line.
    /// </summary>
    public ShapeStyle? ShapeStyle { get => _ShapeStyle; set => UpdateField(ref _ShapeStyle, value, nameof(ShapeStyle)); }

    private ShapeStyle? _ShapeStyle;
    /// <summary>
    /// List of extensions for additional line default properties.
    /// </summary>
    public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

    private ExtensionList? _ExtensionList;
}