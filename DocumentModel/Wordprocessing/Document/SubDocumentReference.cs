using DocumentModel.Math;

namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Paragraph Class.
/// </summary>
public class SubDocumentReference: RelationshipType, 
  IParagraphContent, 
  ISdtRunContent, 
  IBidirectionalContent
{
}