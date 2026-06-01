namespace DocumentModel.Wordprocessing;

/// <summary>
///   Interface Ifor elements Ithat can be included Iin document <see cref="TableRow"/> element.
/// </summary>
public interface ITableRowContent: IModelElement
{
  /// <summary>
  /// Parent as a <see cref="TableRow"/> element.
  /// </summary>
  public new TableRow? Parent
  {
    get => (this as IModelElement).Parent as TableRow;
    set => (this as IModelElement).Parent = value;
  }
}
