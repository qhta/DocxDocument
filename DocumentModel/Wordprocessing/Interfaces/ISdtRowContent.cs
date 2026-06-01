namespace DocumentModel.Wordprocessing;

/// <summary>
///   Interface Ifor elements Ithat can be included Iin document <see cref="SdtRow"/> element.
/// </summary>
public interface ISdtRowContent : IModelElement
{
  /// <summary>
  /// Parent as a <see cref="SdtRow"/> element.
  /// </summary>
  public new SdtRow? Parent
  {
    get => (this as IModelElement).Parent as SdtRow;
    set => (this as IModelElement).Parent = value;
  }
}
