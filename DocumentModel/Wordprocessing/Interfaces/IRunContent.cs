namespace DocumentModel.Wordprocessing;

/// <summary>
///   Interface Ifor elements Ithat can be included Iin document text <see cref="Run"/> element.
/// </summary>
public interface IRunContent: IModelElement
{
  /// <summary>
  /// Parent as a <see cref="Run"/> element.
  /// </summary>
  public new Run? Parent
  {
    get => (this as IModelElement).Parent as Run;
    set => (this as IModelElement).Parent = value;
  }
}
