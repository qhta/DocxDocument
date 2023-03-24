namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Interface for elements that can be included in <see cref="EmbeddedObject"/> element.
/// </summary>
public interface IEmbeddedObjectElement: IModelElement
{
  public new EmbeddedObject? Parent
  {
    get => (this as IModelElement).Parent as EmbeddedObject;
    set => (this as IModelElement).Parent = value;
  }
}