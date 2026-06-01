namespace DocumentModel.Wordprocessing;

/// <summary>
///   Interface Ifor elements Ithat can be included Iin document <see cref="RubyContent"/> element.
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
