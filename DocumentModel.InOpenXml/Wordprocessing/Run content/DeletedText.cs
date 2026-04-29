namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a deleted text element in a WordprocessingML document.
/// </summary>
[XmlRoot("DeletedText", Namespace = "DocumentModel.Wordprocessing")]
[OpenXmlType(typeof(DXW.DeletedText))]
public class DeletedText: TextualElement<DXW.DeletedText>
{
  
}