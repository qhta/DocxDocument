namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Legend Entry.
/// </summary>
[OpenXmlType(typeof(DXDC.LegendEntry))]
[DataContract]
[XmlRoot("LegendEntry", Namespace = "DocumentModel.Drawings.Charts")]
public partial class LegendEntry : ModelElement<DXDC.LegendEntry>
{
 /// <summary>
 ///   Index.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.LegendEntry.Index))]
 public UInt32? Index { get => _Index; set => UpdateField(ref _Index, value, nameof(Index)); }
 private UInt32? _Index;

 /// <summary>
 /// Indicates whether the legend entry is deleted.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.Delete))]
 public bool? Delete { get => _Delete; set => UpdateField(ref _Delete, value, nameof(Delete)); }
 private bool? _Delete;

 /// <summary>
 /// Text properties for the legend entry.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.TextProperties))]
 public TextProperties? TextProperties { get => _TextProperties; set => UpdateField(ref _TextProperties, value, nameof(TextProperties)); }
 private TextProperties? _TextProperties;

 /// <summary>
 /// Extension list for the legend entry.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.ExtensionList))]
 public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }
 private ExtensionList? _ExtensionList;
}