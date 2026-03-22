namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the data binding configuration for a structured document tag (SDT) in a Wordprocessing document.
/// This class provides properties for XML namespace prefix mappings, XPath expressions, and custom XML data storage IDs, enabling advanced binding of SDT content to XML data sources.
/// </summary>
public partial class SdtDataBinding : ModelElement //<DXO10W.SdtDataBinding>
{
    /// <summary>
    /// XML namespace prefix mappings, specifying the prefixes used in XPath expressions for XML data binding.
    /// </summary>
    public string? PrefixMappings { get => _PrefixMappings; set => UpdateField(ref _PrefixMappings, value, nameof(PrefixMappings)); }
    private string? _PrefixMappings;
    /// <summary>
    /// XPath expression used to locate the XML element for data binding.
    /// </summary>
    public string? XPath { get => _XPath; set => UpdateField(ref _XPath, value, nameof(XPath)); }
    private string? _XPath;
    /// <summary>
    /// Custom XML data storage ID, identifying the XML data part to which the SDT is bound.
    /// </summary>
    public string? StoreItemId { get => _StoreItemId; set => UpdateField(ref _StoreItemId, value, nameof(StoreItemId)); }
    private string? _StoreItemId;
}