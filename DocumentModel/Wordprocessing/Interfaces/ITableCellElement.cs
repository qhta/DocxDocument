namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Interface for elements that can be included in document <see cref="TableCell"/> element.
/// </summary>
public interface ITableCellElement: IModelElement
{
  public new TableCell? Parent
  {
    get => (this as IModelElement).Parent as TableCell;
    set => (this as IModelElement).Parent = value;
  }
}