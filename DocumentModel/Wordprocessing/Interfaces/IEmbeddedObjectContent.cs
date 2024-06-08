namespace DocumentModel.Wordprocessing;

/// <summary>
///   Interface for elements that can be included in <see cref="EmbeddedObject"/> element.
/// </summary>
public interface IEmbeddedObjectContent: IModelElement
{
  /// <summary>
  /// Parent as a <see cref="EmbeddedObject"/> element.
  /// </summary>
  //public new EmbeddedObject? Parent
  //{
  //  get => (this as IModelElement).Parent as EmbeddedObject;
  //  set => (this as IModelElement).Parent = value;
  //}
}