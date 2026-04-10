namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents an entry in the data label field table for a chart.
///   Each entry defines a custom field used in data labels, including its unique identifier, formula, and cached values.
/// </summary>
[OpenXmlType(typeof(DXO13DC.DataLabelFieldTableEntry))]
[XmlRoot("DataLabelFieldTableEntry", Namespace = "DocumentModel.Drawings.Charts")]
public partial class DataLabelFieldTableEntry : ModelElement<DXO13DC.DataLabelFieldTableEntry>
{
 /// <summary>
 ///   Unique identifier (GUID) for the text field associated with this entry.
 /// </summary>
 [OpenXmlProperty(nameof(DXO13DC.DataLabelFieldTableEntry.TextFieldGuid))]
 public string? TextFieldGuid { get => _TextFieldGuid; set => UpdateField(ref _TextFieldGuid, value, nameof(TextFieldGuid)); }

 private string? _TextFieldGuid;
 /// <summary>
 ///   Formula used to calculate or retrieve the value for this data label field.
 /// </summary>
 [OpenXmlProperty(nameof(DXO13DC.DataLabelFieldTableEntry.Formula))]
 public string? Formula { get => _Formula; set => UpdateField(ref _Formula, value, nameof(Formula)); }

 private string? _Formula;
 /// <summary>
 ///   Cache containing the values and metadata for this data label field entry.
 /// </summary>
 [OpenXmlProperty(nameof(DXO13DC.DataLabelFieldTableEntry.DataLabelFieldTableCache))]
 public DataLabelFieldTableCache? DataLabelFieldTableCache { get => _DataLabelFieldTableCache; set => UpdateField(ref _DataLabelFieldTableCache, value, nameof(DataLabelFieldTableCache)); }

 private DataLabelFieldTableCache? _DataLabelFieldTableCache;
}