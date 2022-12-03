namespace DocumentModel.Wordprocessing;

/// <summary>
/// Phonetic Guide.
/// </summary>
public interface Ruby // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Phonetic Guide Properties.
  /// </summary>
  public RubyProperties? RubyProperties { get ; set; }
  
  /// <summary>
  /// Phonetic Guide Text.
  /// </summary>
  public RubyContent? RubyContent { get ; set; }
  
  /// <summary>
  /// Phonetic Guide Base Text.
  /// </summary>
  public RubyBase? RubyBase { get ; set; }
  
}
