namespace DocumentModel.Wordprocessing;

/// <summary>
///   Interface for elements that can be included in document <see cref="Hyperlink"/> element.
/// </summary>
public interface IHyperlinkContent: IModelElement
{
  /// <summary>
  /// Parent as a <see cref="Hyperlink"/> element.
  /// </summary>
  public new Hyperlink? Parent
  {
    get => (this as IModelElement).Parent as Hyperlink;
    set => (this as IModelElement).Parent = value;
  }
}