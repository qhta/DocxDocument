namespace DocumentModel.Wordprocessing;

/// <summary>
/// Phonetic Guide.
/// </summary>
public class RubyImpl: ModelElementImpl, Ruby
{
  public DocumentFormat.OpenXml.Wordprocessing.Ruby? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Ruby?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Phonetic Guide Properties.
  /// </summary>
  public RubyProperties? RubyProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Phonetic Guide Text.
  /// </summary>
  public RubyContent? RubyContent
  {
    get;
    set;
  }
  
  /// <summary>
  /// Phonetic Guide Base Text.
  /// </summary>
  public RubyBase? RubyBase
  {
    get;
    set;
  }
  
}
