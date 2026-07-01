namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Custom Split.
/// </summary>
[OpenXmlType(typeof(DXDC.CustomSplit))]
[DataContract]
[XmlRoot("CustomSplit", Namespace = "DocumentModel.Drawings.Charts")]
public class CustomSplit : ValueCollection<UInt32>
{
}