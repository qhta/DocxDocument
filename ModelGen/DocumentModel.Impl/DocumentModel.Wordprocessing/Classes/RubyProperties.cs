namespace DocumentModel.Wordprocessing;

/// <summary>
/// Phonetic Guide Properties.
/// </summary>
public class RubyPropertiesImpl: ModelElementImpl, RubyProperties
{
  public DocumentFormat.OpenXml.Wordprocessing.RubyProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.RubyProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Phonetic Guide Text Alignment.
  /// </summary>
  public RubyAlignKind? RubyAlign
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RubyAlign>();
        return (RubyAlignKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RubyAlign>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.RubyAlignValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.RubyAlign{ Val = (DocumentFormat.OpenXml.Wordprocessing.RubyAlignValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Phonetic Guide Text Font Size.
  /// </summary>
  public String? PhoneticGuideTextFontSize
  {
    get;
    set;
  }
  
  /// <summary>
  /// Distance Between Phonetic Guide Text and Phonetic Guide Base Text.
  /// </summary>
  public Int16? PhoneticGuideRaise
  {
    get;
    set;
  }
  
  /// <summary>
  /// Phonetic Guide Base Text Font Size.
  /// </summary>
  public String? PhoneticGuideBaseTextSize
  {
    get;
    set;
  }
  
  /// <summary>
  /// Language ID for Phonetic Guide.
  /// </summary>
  public String? LanguageId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Invalidated Field Cache.
  /// </summary>
  public Boolean? Dirty
  {
    get;
    set;
  }
  
}
