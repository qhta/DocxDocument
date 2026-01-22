namespace DocumentModel.Drawings;
/// <summary>
///   Represents default formatting properties for objects in a theme, including shape, line, and text defaults.
/// </summary>
[OpenXmlType(typeof(DXD.ObjectDefaults))]
/// <summary>
///   Represents default formatting properties for objects in a theme, including shape, line, and text defaults.
/// </summary>
public partial class ObjectDefaults : ModelElement<DXD.ObjectDefaults>, IExtendableElement
{
    /// <summary>
    ///   Default formatting properties for shapes.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ObjectDefaults.ShapeDefault))]
    public ShapeDefault? ShapeDefault { get => _ShapeDefault; set => UpdateField(ref _ShapeDefault, value, nameof(ShapeDefault)); }

    private ShapeDefault? _ShapeDefault;
    /// <summary>
    ///   Default formatting properties for lines.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ObjectDefaults.LineDefault))]
    public LineDefault? LineDefault { get; set; }

    /// <summary>
    ///   Default formatting properties for text.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ObjectDefaults.TextDefault))]
    public TextDefault? TextDefault { get; set; }

    /// <summary>
    /// List of extensions for future extensions of the element type.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.ObjectDefaults.ExtensionList))]
    public ExtensionList? ExtensionList { get; set; }
}