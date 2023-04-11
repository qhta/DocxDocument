namespace DocumentModel.Wordprocessing;

/// <summary>
///   Interface for marker elements that can be included in many document elements.
/// </summary>
public interface ICommonContent: IBodyContent, IParagraphContent, ITableContent, ITableRowContent, ITableCellContent, 
  ISdtBlockContent,
  ISdtRunContent, 
  ISdtRowContent, 
  ISdtCellContent,
  ICommentContent
{
}