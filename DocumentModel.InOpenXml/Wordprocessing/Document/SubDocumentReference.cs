using DocumentModel.Math;
namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a reference to a subdocument in a WordprocessingML document.
/// This interface extends <see cref="RelationshipType"/>, <see cref="IParagraphContent"/>, <see cref="SdtRunContent"/>, and <see cref="BidirectionalContent"/>, enabling advanced linking, embedding, and referencing of external or modular document content within paragraphs, structured document tags, and bidirectional content flows.
/// </summary>
public interface SubDocumentReference : RelationshipType,
  IParagraphContent,
  SdtRunContent,
  BidirectionalContent
{
}