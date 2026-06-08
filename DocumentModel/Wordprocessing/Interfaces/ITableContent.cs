namespace DocumentModel.Wordprocessing;

/// <summary>
///   Interface for elements Ithat can be included in document <see cref="ITable"/> element.
/// </summary>
public interface ITableContent: IModelElement
{
  /// <summary>
  /// Parent as a <see cref="ITable"/> element.
  /// </summary>
  public new ITable? Parent
  {
    get => (this as IModelElement).Parent as ITable;
    set => (this as IModelElement).Parent = value;
  }
}
