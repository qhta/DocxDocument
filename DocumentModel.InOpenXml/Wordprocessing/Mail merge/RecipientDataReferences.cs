namespace DocumentModel.Wordprocessing;

/// <summary>
///  Represents a collection of mail merge recipient data references in a WordprocessingML document.
/// </summary>
[OpenXmlType(typeof(DXW.RecipientDataReference))]
[DataContract]
[XmlRoot("RecipientDataRef", Namespace = "DocumentModel.Wordprocessing")]
public class RecipientDataReferences: ElementCollection<RecipientDataRef>
{

}
