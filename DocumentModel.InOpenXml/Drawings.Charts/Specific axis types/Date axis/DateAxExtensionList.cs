namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a collection of date axis extensions.
/// </summary>
[OpenXmlType(typeof(DXDC.DateAxExtensionList))]
[DataContract]
[XmlRoot("DateAxExtensionList", Namespace = "DocumentModel.Drawings.Charts")]
public class DateAxExtensionList : ModelElementCollection<DateAxExtension>
{
}