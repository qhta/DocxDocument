using DocumentModel.BaseTypes;
namespace DocumentModel.Wordprocessing;
/// <summary>
///   Interface for elements that can be included in document <see cref="TableRow"/> element.
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