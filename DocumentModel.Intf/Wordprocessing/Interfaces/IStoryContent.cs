namespace DocumentModel.Wordprocessing;

/// <summary>
///   Interface for elements that can be included in document <see cref="Body"/> element.
/// </summary>
public interface IStoryContent: IModelElement
{
  /// <summary>
  /// Parent as a <see cref="Body"/> element.
  /// </summary>
  public new Body? Parent
  {
    get => (this as IModelElement).Parent as Body;
    set => (this as IModelElement).Parent = value;
  }
}