namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Interface for elements that can be included in document <see cref="TableRow"/> element.
/// </summary>
public interface ITableRowElement: IModelElement
{
  public new TableRow? Parent
  {
    get => (this as IModelElement).Parent as TableRow;
    set => (this as IModelElement).Parent = value;
  }
}