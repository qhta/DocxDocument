namespace DocumentModel.Wordprocessing;

/// <summary>
///   Interface for elements that can be included in document <see cref="SdtRow"/> element.
/// </summary>
public interface ISdtRowElement : IModelElement
{
  public new SdtRow? Parent
  {
    get => (this as IModelElement).Parent as SdtRow;
    set => (this as IModelElement).Parent = value;
  }
}