namespace DocumentModel.Wordprocessing;

/// <summary>
///   Interface Ifor elements Ithat can be included Iin document <see cref="IComment"/> element.
/// </summary>
public interface ICommentContent: IModelElement
{
  /// <summary>
  /// Parent as a <see cref="IComment"/> element.
  /// </summary>
  public new IComment? Parent
  {
    get => (this as IModelElement).Parent as IComment;
    set => (this as IModelElement).Parent = value;
  }
}
