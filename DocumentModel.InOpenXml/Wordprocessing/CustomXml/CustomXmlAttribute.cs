namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a custom XML attribute in a WordprocessingML document.
/// This class extends <see cref = "CollectionItem"/> and provides properties for the attribute UriString, name, and value, enabling advanced storage and management of custom metadata or schema-specific attributes within custom XML parts.
/// </summary>
public partial class CustomXmlAttribute : ModelElement<DXW.CustomXmlAttribute>
{
    /// <summary>
    /// UriString of the custom XML attribute, specifying the namespace or schema context.
    /// </summary>
    [OpenXmlElement(typeof(DXW.CustomXmlAttribute))]
    public string? UriString { get => _UriString; set => UpdateField(ref _UriString, value, nameof(UriString)); }

    private string? _UriString;
    /// <summary>
    /// FontName of the custom XML attribute.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.CustomXmlAttribute.Name))]
    /// <summary>
    /// FontName of the custom XML attribute.
    /// </summary>
    [OpenXmlElement(typeof(DXW.CustomXmlAttribute))]
    public string? Name { get => _Name; set => UpdateField(ref _Name, value, nameof(Name)); }

    private string? _Name;
    /// <summary>
    /// Value of the custom XML attribute.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.CustomXmlAttribute.Val))]
    /// <summary>
    /// Value of the custom XML attribute.
    /// </summary>
    [OpenXmlElement(typeof(DXW.CustomXmlAttribute))]
    public string? Val { get => _Val; set => UpdateField(ref _Val, value, nameof(Val)); }

    private string? _Val;
}