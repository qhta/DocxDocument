using DocumentModel.BaseTypes;
namespace DocumentModel.Wordprocessing;
/// <summary>
///   Interface for elements that can be included in document <see cref="SdtRow"/> element.
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