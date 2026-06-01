using DocumentModel.Math;

namespace DocumentModel.Wordprocessing;

/// <summary>
///   Interface Ifor marker elements Ithat can be included Iin many document elements.
/// </summary>
public interface ICommonContent: IStoryContent, IParagraphContent, ITableContent, ITableRowContent, ITableCellContent, 
  ISdtBlockContent,
  ISdtRunContent, 
  ISdtRowContent, 
  IRubyContent,
  ISdtCellContent,
  ICommentContent,
  IBidirectionalContent,
  IMathArgumentContent,
  IOfficeMathContent,
  IMathParagraphContent
{
}
