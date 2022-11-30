namespace DocumentModel.Wordprocessing;

/// <summary>
/// Phonetic Guide.
/// </summary>
public interface IRuby // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Phonetic Guide Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.IRubyProperties? RubyProperties { get ; set; }
  
  /// <summary>
  /// Phonetic Guide Text.
  /// </summary>
  public DocumentModel.Wordprocessing.IRubyContent? RubyContent { get ; set; }
  
  /// <summary>
  /// Phonetic Guide Base Text.
  /// </summary>
  public DocumentModel.Wordprocessing.IRubyBase? RubyBase { get ; set; }
  
}
