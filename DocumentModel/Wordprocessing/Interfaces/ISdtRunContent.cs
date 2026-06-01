namespace DocumentModel.Wordprocessing;

/// <summary>
///   Interface Ifor elements Ithat can be included Iin document <see cref="SdtRun"/> element.
/// </summary>
public interface ISdtRunContent : IModelElement
{
  /// <summary>
  /// Parent as a <see cref="SdtRun"/> element.
  /// </summary>
  public new SdtRun? Parent
  {
    get => (this as IModelElement).Parent as SdtRun;
    set => (this as IModelElement).Parent = value;
  }
}
