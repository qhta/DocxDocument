namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a cell-level structured document tag in a Wordprocessing document.
/// This class provides properties for SDT configuration and end character formatting, enabling advanced management and customization of structured document tags for table cells.
/// </summary>
public partial class SdtCell : ModelElement<DXW.SdtCell>, ITableRowContent, ISdtCellContent
{
    /// <summary>
    /// Specifies the set of properties applied to this structured document tag.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.SdtCell.SdtProperties))]
    /// <summary>
    /// Specifies the set of properties applied to this structured document tag.
    /// </summary>
    [OpenXmlElement(typeof(DXW.SdtCell))]
    public SdtProperties? SdtProperties { get => _SdtProperties; set => UpdateField(ref _SdtProperties, value, nameof(SdtProperties)); }

    private SdtProperties? _SdtProperties;
    /// <summary>
    /// Specifies the properties applied to the physical character that delimits the end of a structured document tag.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.SdtCell.SdtEndCharProperties))]
    /// <summary>
    /// Specifies the properties applied to the physical character that delimits the end of a structured document tag.
    /// </summary>
    [OpenXmlElement(typeof(DXW.SdtCell))]
    public SdtEndCharProperties? SdtEndCharProperties { get => _SdtEndCharProperties; set => UpdateField(ref _SdtEndCharProperties, value, nameof(SdtEndCharProperties)); }

    private SdtEndCharProperties? _SdtEndCharProperties;
}