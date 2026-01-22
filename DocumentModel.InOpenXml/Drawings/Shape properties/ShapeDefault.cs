namespace DocumentModel.Drawings;
/// <summary>
///   Represents default shape properties, including shape, body, list, and style settings.
/// </summary>
public partial class ShapeDefault : ModelElement<DXD.ShapeDefault>, IExtendableElement
{
    /// <summary>
    ///   Default shape properties.
    /// </summary>
    public ShapeProperties? ShapeProperties { get => _ShapeProperties; set => UpdateField(ref _ShapeProperties, value, nameof(ShapeProperties)); }

    private ShapeProperties? _ShapeProperties;
    /// <summary>
    ///   Default body properties for the shape.
    /// </summary>
    public BodyProperties? BodyProperties { get; set; }
    /// <summary>
    ///   Default list style for the shape.
    /// </summary>
    public ListStyle? ListStyle { get; set; }
    /// <summary>
    ///   Default shape style.
    /// </summary>
    public ShapeStyle? ShapeStyle { get; set; }
    public IExtensionList? ExtensionList { get; set; }
}