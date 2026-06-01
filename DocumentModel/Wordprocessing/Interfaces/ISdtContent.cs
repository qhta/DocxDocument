namespace DocumentModel.Wordprocessing;
/// <summary>
///   Interface Ifor elements Ithat can be included Iin a structured document tag element
/// </summary>
public interface ISdtContent: IModelElement
{
  /// <summary>
  /// Parent as a <see cref="SdtBlock"/> element.
  /// </summary>
  public new SdtBlock? Parent
  {
    get => (this as IModelElement).Parent as SdtBlock;
    set => (this as IModelElement).Parent = value;
  }
}
