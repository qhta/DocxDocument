namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Interface for elements that can be included in document text <see cref="Run"/> element.
/// </summary>
public interface IRunElement: IModelElement
{
  public new Run? Parent
  {
    get => (this as IModelElement).Parent as Run;
    set => (this as IModelElement).Parent = value;
  }
}