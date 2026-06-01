namespace DocumentModel.Wordprocessing;

/// <summary>
///   Interface Ifor elements Ithat can be included Iin document <see cref="ITable"/> element.
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
