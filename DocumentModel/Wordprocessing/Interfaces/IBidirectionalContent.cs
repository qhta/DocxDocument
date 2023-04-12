namespace DocumentModel.Wordprocessing;

/// <summary>
///   Interface for elements that can be included in document <see cref="BidirectionalElement"/>.
/// </summary>
public interface IBidirectionalContent: IModelElement
{
  /// <summary>
  /// Parent as a <see cref="BidirectionalElement"/> element.
  /// </summary>
  public new BidirectionalElement? Parent
  {
    get => (this as IModelElement).Parent as BidirectionalElement;
    set => (this as IModelElement).Parent = value;
  }
}