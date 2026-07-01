namespace DocumentModel.Wordprocessing;
/// <summary>
///   Represents a collection of bibliographic sources.
/// </summary>
[OpenXmlType(typeof(DMW.Source))]
[DataContract]
[XmlRoot("Sources", Namespace = "DocumentModel.Wordprocessing")]
public class Sources : ElementCollection<DMW.Source>
{
}