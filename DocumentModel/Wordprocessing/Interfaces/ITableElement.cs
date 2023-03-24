namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Interface for elements that can be included in document <see cref="Table"/> element.
/// </summary>
public interface ITableElement: IModelElement
{
  public new Table? Parent
  {
    get => (this as IModelElement).Parent as Table;
    set => (this as IModelElement).Parent = value;
  }
}