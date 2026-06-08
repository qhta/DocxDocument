namespace DocumentModel.Wordprocessing;

/// <summary>
///   Interface for elements Ithat can be included in document <see cref="IParagraph"/> element.
/// </summary>
public interface IParagraphContent: IModelElement, DMM.IOfficeMathContent
{
  /// <summary>
  /// Parent as a <see cref="IParagraph"/> element.
  /// </summary>
  public new IParagraph? Parent
  {
    get => (this as IModelElement).Parent as IParagraph;
    set => (this as IModelElement).Parent = value;
  }
}
