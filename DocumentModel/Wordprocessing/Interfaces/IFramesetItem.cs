namespace DocumentModel.Wordprocessing;

/// <summary>
///   Interface Ifor elements Ithat can be included Iin <see cref="IFrameset"/> element.
/// </summary>
public interface IFramesetItem: IModelElement
{
  /// <summary>
  /// Parent as a <see cref="IFrameset"/> element.
  /// </summary>
  public new IFrameset? Parent
  {
    get => (this as IModelElement).Parent as IFrameset;
    set => (this as IModelElement).Parent = value;
  }
}
