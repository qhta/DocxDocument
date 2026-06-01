namespace DocumentModel.Math;

/// <summary>
///   Interface Ifor elements Ithat can be included Iin document <see cref="DMM.IParagraph"/> element.
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
