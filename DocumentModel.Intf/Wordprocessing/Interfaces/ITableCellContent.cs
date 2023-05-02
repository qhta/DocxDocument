namespace DocumentModel.Wordprocessing;

/// <summary>
///   Interface for elements that can be included in document <see cref="TableCell"/> element.
/// </summary>
public interface ITableCellContent: IModelElement
{
  /// <summary>
  /// Parent as a <see cref="TableCell"/> element.
  /// </summary>
  public new TableCell? Parent
  {
    get => (this as IModelElement).Parent as TableCell;
    set => (this as IModelElement).Parent = value;
  }
}