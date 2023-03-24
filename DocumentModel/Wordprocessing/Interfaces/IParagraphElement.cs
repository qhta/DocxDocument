namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Interface for elements that can be included in document <see cref="Paragraph"/> element.
/// </summary>
public interface IParagraphElement: IModelElement
{
  public new Paragraph? Parent
  {
    get => (this as IModelElement).Parent as Paragraph;
    set => (this as IModelElement).Parent = value;
  }
}