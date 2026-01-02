using DocumentModel.BaseTypes;
namespace DocumentModel.Wordprocessing;
/// <summary>
///   Interface for elements that can be included in document <see cref="RubyContent"/> element.
/// </summary>
public interface IRubyContent : IModelElement
{
  /// <summary>
  /// Parent as a <see cref="RubyContent"/> element.
  /// </summary>
  public new RubyContent? Parent
  {
    get => (this as IModelElement).Parent as RubyContent;
    set => (this as IModelElement).Parent = value;
  }
}