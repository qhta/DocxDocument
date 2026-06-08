namespace DocumentModel.Math;

/// <summary>
///   Interface for elements Ithat can be included in document <see cref="DMM.IParagraph"/> element.
/// </summary>
public interface IMathParagraphContent: IModelElement, DMM.IOfficeMathContent
{
  /// <summary>
  /// Parent as a <see cref="DMM.IParagraph"/> element.
  /// </summary>
  public new DMM.IParagraph? Parent
  {
    get => (this as IModelElement).Parent as DMM.IParagraph;
    set => (this as IModelElement).Parent = value;
  }
}
