namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Defines the SampleDataType Class.
/// </summary>
[OpenXmlType(typeof(DXDD.SampleDataType))]
[DataContract]
[XmlRoot("SampleDataType", Namespace = "DocumentModel.Drawings.Diagrams")]
public partial class SampleDataType : ModelElement<DXDD.SampleDataType>
{
 /// <summary>
 ///   Use Default
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.SampleDataType.UseDefault))]
 public bool? UseDefault { get => _UseDefault; set => UpdateField(ref _UseDefault, value, nameof(UseDefault)); }
 private bool? _UseDefault;

 /// <summary>
 ///   Data Model.
 /// </summary>
 [OpenXmlProperty(nameof(DXDD.SampleDataType.DataModel))]
 public DataModel? DataModel { get => _DataModel; set => UpdateField(ref _DataModel, value, nameof(DataModel)); }
 private DataModel? _DataModel;
}