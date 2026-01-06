using DocumentModel.Math;
namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the Paragraph Class.
/// </summary>
public interface SubDocumentReference: RelationshipType, 
  ParagraphContent, 
  SdtRunContent, 
  BidirectionalContent
{
}