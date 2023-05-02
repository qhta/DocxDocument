namespace DocumentModel.Wordprocessing;

/// <summary>
///   Interface for elements that can be included in document <see cref="Table"/> element.
/// </summary>
public interface ITableContent: IModelElement
{
  /// <summary>
  /// Parent as a <see cref="Table"/> element.
  /// </summary>
  public new Table? Parent
  {
    get => (this as IModelElement).Parent as Table;
    set => (this as IModelElement).Parent = value;
  }
}