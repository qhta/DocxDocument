using DocumentModel.BaseTypes;
namespace DocumentModel.Math;
/// <summary>
///   Interface for elements that can be included in document <see cref="DMM.Paragraph"/> element.
/// </summary>
public interface IMathParagraphContent: IModelElement, DMM.IOfficeMathContent
{
  /// <summary>
  /// Parent as a <see cref="DMM.Paragraph"/> element.
  /// </summary>
  public new DMM.Paragraph? Parent
  {
    get => (this as IModelElement).Parent as DMM.Paragraph;
    set => (this as IModelElement).Parent = value;
  }
}