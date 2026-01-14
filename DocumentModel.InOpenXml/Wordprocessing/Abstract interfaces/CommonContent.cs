using DocumentModel.Math;
namespace DocumentModel.Wordprocessing;
/// <summary>
///   Interface for marker elements that can be included in many document elements.
/// </summary>
public interface CommonContent: StoryContent, IParagraphContent, TableContent, TableRowContent, TableCellContent, 
  SdtBlockContent,
  SdtRunContent, 
  SdtRowContent, 
  RubyContent,
  SdtCellContent,
  CommentContent,
  BidirectionalContent,
  IMathArgumentContent,
  IOfficeMathContent,
  IMathParagraphContent
{
}