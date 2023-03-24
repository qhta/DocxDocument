namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Interface for elements that can be included in document <see cref="SdtRun"/> element.
/// </summary>
public interface ISdtRunElement: IModelElement
{
    public new Run? Parent
  {
    get => (this as IModelElement).Parent as Run;
    set => (this as IModelElement).Parent = value;
  }
}