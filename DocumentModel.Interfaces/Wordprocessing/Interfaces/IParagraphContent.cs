using DocumentModel.BaseTypes;
namespace DocumentModel.Wordprocessing;
/// <summary>
///   Interface for elements that can be included in document <see cref="Paragraph"/> element.
/// </summary>
public interface IParagraphContent: IModelElement, DMM.IOfficeMathContent
{
  /// <summary>
  /// Parent as a <see cref="Paragraph"/> element.
  /// </summary>
  public new Paragraph? Parent
  {
    get => (this as IModelElement).Parent as Paragraph;
    set => (this as IModelElement).Parent = value;
  }
}