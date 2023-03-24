namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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