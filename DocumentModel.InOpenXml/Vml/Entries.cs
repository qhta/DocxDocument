namespace DocumentModel.Vml;
/// <summary>
///   Represents a collection of regrouping history entries for VML shape groups.
/// </summary>
[OpenXmlType(typeof(Entry))]
[DataContract]
[XmlRoot("Entries", Namespace = "DocumentModel.Vml")]
public class Entries : ElementCollection<Entry>
{
}