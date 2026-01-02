using DocumentModel.BaseTypes;
namespace DocumentModel.Wordprocessing;
/// <summary>
///   Interface for elements that can be included in document <see cref="Comment"/> element.
/// </summary>
public interface ICommentContent: IModelElement
{
  /// <summary>
  /// Parent as a <see cref="Comment"/> element.
  /// </summary>
  public new Comment? Parent
  {
    get => (this as IModelElement).Parent as Comment;
    set => (this as IModelElement).Parent = value;
  }
}