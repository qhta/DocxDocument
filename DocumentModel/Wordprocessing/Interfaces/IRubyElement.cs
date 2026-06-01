namespace DocumentModel.Wordprocessing;

/// <summary>
///   Interface Ifor Ruby elements.
/// </summary>
public interface IRubyElement : IModelElement
{
  /// <summary>
  /// Specifies whether this is a Ruby element.
  /// </summary>
  public bool Ruby { get; set; }
}
