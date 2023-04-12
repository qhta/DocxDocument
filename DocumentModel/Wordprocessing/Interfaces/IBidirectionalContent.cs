namespace DocumentModel.Wordprocessing;

/// <summary>
///   Interface for elements that can be included in document <see cref="BidirectionalEmbedding"/> element.
/// </summary>
public interface IBidirectionalContent: IModelElement
{
  /// <summary>
  /// Parent as a <see cref="BidirectionalOverride"/> element.
  /// </summary>
  public new BidirectionalOverride? Parent
  {
    get => (this as IModelElement).Parent as BidirectionalOverride;
    set => (this as IModelElement).Parent = value;
  }
}