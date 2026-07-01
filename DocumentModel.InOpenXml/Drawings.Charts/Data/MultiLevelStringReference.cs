namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a reference to multi-level string data for a chart axis or series.
/// </summary>
[OpenXmlType(typeof(DXDC.MultiLevelStringReference))]
[DataContract]
[XmlRoot("MultiLevelStringReference", Namespace = "DocumentModel.Drawings.Charts")]
public partial class MultiLevelStringReference : ModelElement<DXDC.MultiLevelStringReference>
{
 /// <summary>
 ///   Formula used to reference the multi-level string data.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.MultiLevelStringReference.Formula))]
 public string? Formula { get => _Formula; set => UpdateField(ref _Formula, value, nameof(Formula)); }
 private string? _Formula;

 /// <summary>
 ///   Cache containing the multi-level string values.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.MultiLevelStringReference.MultiLevelStringCache))]
 public MultiLevelStringCache? MultiLevelStringCache { get => _MultiLevelStringCache; set => UpdateField(ref _MultiLevelStringCache, value, nameof(MultiLevelStringCache)); }
 private MultiLevelStringCache? _MultiLevelStringCache;

 /// <summary>
 ///   Collection of extension elements for additional reference properties.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.MultiLevelStringReference.MultiLvlStrRefExtensionList))]
 public MultiLvlStrRefExtensionList? MultiLvlStrRefExtensionList { get => _MultiLvlStrRefExtensionList; set => UpdateField(ref _MultiLvlStrRefExtensionList, value, nameof(MultiLvlStrRefExtensionList)); }
 private MultiLvlStrRefExtensionList? _MultiLvlStrRefExtensionList;
}