namespace DocumentModel.Wordprocessing;

/// <summary>
///   Interface for elements that can be included in document <see cref="SdtBlock"/> element.
/// </summary>
public interface ISdtBlockContent: IModelElement
{
  /// <summary>
  /// Parent as a <see cref="SdtBlock"/> element.
  /// </summary>
  public new SdtBlock? Parent
  {
    get => (this as IModelElement).Parent as SdtBlock;
    set => (this as IModelElement).Parent = value;
  }
}