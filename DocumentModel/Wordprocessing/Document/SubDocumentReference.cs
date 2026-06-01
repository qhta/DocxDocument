using DocumentModel.Math;

namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the IParagraph Class.
/// </summary>
public class SubDocumentReference: RelationshipType, 
  IParagraphContent, 
  ISdtRunContent, 
  IBidirectionalContent
{
}
