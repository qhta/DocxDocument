namespace DocumentModel.Wordprocessing;

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