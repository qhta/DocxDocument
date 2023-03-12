namespace DocumentModel.Wordprocessing;

/// <summary>
///   Interface for marker elements that can be included in many document elements.
/// </summary>
public interface ICommonElement: IBodyElement, IParagraphElement, ITableElement, ITableRowElement, ITableCellElement, 
  ISdtRowElement, 
  ISdtRunElement, 
  ISdtBlockElement
{
}