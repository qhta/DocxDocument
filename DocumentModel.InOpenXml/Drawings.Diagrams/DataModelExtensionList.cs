namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Defines the DataModelExtensionList Class.
/// </summary>
[OpenXmlType(typeof(DXDD.DataModelExtensionList))]
[DataContract]
[XmlRoot("DataModelExtensionList", Namespace = "DocumentModel.Drawings.Diagrams")]
public class DataModelExtensionList : ModelElementCollection<DataModelExtension, DXDD.DataModelExtensionList, DXD.DataModelExtension>
{
}