namespace DocumentModel.Wordprocessing;

/// <summary>
/// Phonetic Guide.
/// </summary>
public partial class Ruby
{
  /// <summary>
  /// Phonetic Guide Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.RubyProperties? RubyProperties { get; set; }
  
  /// <summary>
  /// Phonetic Guide Text.
  /// </summary>
  public DocumentModel.Wordprocessing.RubyContent? RubyContent { get; set; }
  
  /// <summary>
  /// Phonetic Guide Base Text.
  /// </summary>
  public DocumentModel.Wordprocessing.RubyBase? RubyBase { get; set; }
  
}
