namespace DocumentModel.Wordprocessing;

/// <summary>
///   Interface for elements that can be included in document <see cref="SdtContentBlock"/> element.
/// </summary>
public interface ISdtBlockElement: IModelElement
{
  public new SdtBlock? Parent
  {
    get => (this as IModelElement).Parent as SdtBlock;
    set => (this as IModelElement).Parent = value;
  }
}