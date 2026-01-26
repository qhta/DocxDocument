namespace DocumentModel.Wordprocessing;
/// <summary>
/// Specifies the presence of a structured document tag around a single table row.
/// This class represents a collection of structured document tag row content and provides properties for tag configuration and end character formatting, enabling advanced handling of structured document tags for table rows.
/// </summary>
[OpenXmlType(typeof(DXW.SdtRow))]
public partial class SdtRow : ModelElement<DXW.SdtRow>, ITableContent, ISdtRowContent
{
 /// <summary>
 /// Specifies the set of properties applied to this structured document tag.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.SdtRow.SdtProperties))]
 /// <summary>
 /// Specifies the set of properties applied to this structured document tag.
 /// </summary>
 [OpenXmlElement(typeof(DXW.SdtRow))]
 public SdtProperties? SdtProperties { get => _SdtProperties; set => UpdateField(ref _SdtProperties, value, nameof(SdtProperties)); }

 private SdtProperties? _SdtProperties;
 /// <summary>
 /// Specifies the properties applied to the physical character that delimits the end of a structured document tag.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.SdtRow.SdtEndCharProperties))]
 /// <summary>
 /// Specifies the properties applied to the physical character that delimits the end of a structured document tag.
 /// </summary>
 [OpenXmlElement(typeof(DXW.SdtRow))]
 public SdtEndCharProperties? SdtEndCharProperties { get => _SdtEndCharProperties; set => UpdateField(ref _SdtEndCharProperties, value, nameof(SdtEndCharProperties)); }

 private SdtEndCharProperties? _SdtEndCharProperties;
}