using DocumentModel.Math;

namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a reference to a subdocument in a WordprocessingML document.
/// This class extends <see cref = "ReferenceRelationship{T}"/>, <see cref = "IParagraphContent"/>, <see cref = "ISdtRunContent"/>, and <see cref = "IBidirectionalContent"/>, enabling advanced linking, embedding, and referencing of external or modular document content within paragraphs, structured document tags, and bidirectional content flows.
/// </summary>
[OpenXmlType(typeof(DXW.SubDocumentReference))]
[XmlRoot("SubDocumentReference", Namespace = "DocumentModel.Wordprocessing")]
public class SubDocumentReference : RelationshipType<DXW.SubDocumentReference>, IParagraphContent, ISdtRunContent, IBidirectionalContent
{
}