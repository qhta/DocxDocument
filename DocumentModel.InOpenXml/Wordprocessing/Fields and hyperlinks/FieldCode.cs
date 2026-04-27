namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a deleted field code within a WordprocessingML document. This class corresponds to the <c>DeletedFieldCode</c> element in the WordprocessingML schema and is used to represent field codes that have been marked as deleted in the document. The DeletedFieldCode class provides a strongly-typed representation for working with deleted field code content in Open XML word processing documents.
/// </summary>

[OpenXmlType(typeof(DXW.DeletedFieldCode))]
[XmlRoot("DeletedFieldCode", Namespace = "DocumentModel.Wordprocessing")]
public class DeletedFieldCode : TextualElement<DXW.DeletedFieldCode>
{
}