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
  
  public RubyImpl(): base() {}
  
  public RubyImpl(DocumentFormat.OpenXml.Wordprocessing.Ruby openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Phonetic Guide Properties.
  /// </summary>
  public RubyProperties? RubyProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Phonetic Guide Text.
  /// </summary>
  public RubyContent? RubyContent
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Phonetic Guide Base Text.
  /// </summary>
  public RubyBase? RubyBase
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
