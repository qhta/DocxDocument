namespace DocumentModel.Wordprocessing;

/// <summary>
///   Interface for elements that can be included in <see cref="Frameset"/> element.
/// </summary>
public interface IFramesetItem: IModelElement
{
  /// <summary>
  /// Parent as a <see cref="Frameset"/> element.
  /// </summary>
  public new Frameset? Parent
  {
    get => (this as IModelElement).Parent as Frameset;
    set => (this as IModelElement).Parent = value;
  }
}