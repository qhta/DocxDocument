namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Interface for marker elements that can be included in many document elements.
/// </summary>
public interface ICommonElement: IBodyElement, IParagraphElement, ITableElement, ITableRowElement, ITableCellElement, 
  ISdtBlockElement,
  ISdtRunElement, 
  ISdtRowElement, 
  ISdtCellElement
{
}