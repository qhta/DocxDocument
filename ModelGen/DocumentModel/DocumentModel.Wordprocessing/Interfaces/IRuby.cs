namespace DocumentModel.Wordprocessing;

/// <summary>
/// Phonetic Guide.
/// </summary>
public interface IRuby // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Phonetic Guide Properties.
  /// </summary>
  public IRubyProperties? RubyProperties { get ; set; }
  
  /// <summary>
  /// Phonetic Guide Text.
  /// </summary>
  public IRubyContent? RubyContent { get ; set; }
  
  /// <summary>
  /// Phonetic Guide Base Text.
  /// </summary>
  public IRubyBase? RubyBase { get ; set; }
  
}
