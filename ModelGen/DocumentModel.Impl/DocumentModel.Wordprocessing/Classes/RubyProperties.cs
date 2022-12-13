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
  
  public RubyPropertiesImpl(): base() {}
  
  public RubyPropertiesImpl(DocumentFormat.OpenXml.Wordprocessing.RubyProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Phonetic Guide Text Alignment.
  /// </summary>
  public DocumentModel.Wordprocessing.RubyAlignKind? RubyAlign
  {
    get => (DocumentModel.Wordprocessing.RubyAlignKind?)OpenXmlElement?.RubyAlign?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.RubyAlign != null)
        {
          if (value is not null)
            OpenXmlElement.RubyAlign.Val = (DocumentFormat.OpenXml.Wordprocessing.RubyAlignValues?)value;
          else
            OpenXmlElement.RubyAlign = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.RubyAlign = new DocumentFormat.OpenXml.Wordprocessing.RubyAlign{ Val = (DocumentFormat.OpenXml.Wordprocessing.RubyAlignValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Phonetic Guide Text Font Size.
  /// </summary>
  public String? PhoneticGuideTextFontSize
  {
    get => (System.String?)OpenXmlElement?.PhoneticGuideTextFontSize?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.PhoneticGuideTextFontSize != null)
        {
          if (value is not null)
            OpenXmlElement.PhoneticGuideTextFontSize.Val = (System.String?)value;
          else
            OpenXmlElement.PhoneticGuideTextFontSize = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.PhoneticGuideTextFontSize = new DocumentFormat.OpenXml.Wordprocessing.PhoneticGuideTextFontSize{ Val = (System.String?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Distance Between Phonetic Guide Text and Phonetic Guide Base Text.
  /// </summary>
  public Int16? PhoneticGuideRaise
  {
    get => (System.Int16?)OpenXmlElement?.PhoneticGuideRaise?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.PhoneticGuideRaise != null)
        {
          if (value is not null)
            OpenXmlElement.PhoneticGuideRaise.Val = (System.Int16?)value;
          else
            OpenXmlElement.PhoneticGuideRaise = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.PhoneticGuideRaise = new DocumentFormat.OpenXml.Wordprocessing.PhoneticGuideRaise{ Val = (System.Int16?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Phonetic Guide Base Text Font Size.
  /// </summary>
  public String? PhoneticGuideBaseTextSize
  {
    get => (System.String?)OpenXmlElement?.PhoneticGuideBaseTextSize?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.PhoneticGuideBaseTextSize != null)
        {
          if (value is not null)
            OpenXmlElement.PhoneticGuideBaseTextSize.Val = (System.String?)value;
          else
            OpenXmlElement.PhoneticGuideBaseTextSize = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.PhoneticGuideBaseTextSize = new DocumentFormat.OpenXml.Wordprocessing.PhoneticGuideBaseTextSize{ Val = (System.String?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Language ID for Phonetic Guide.
  /// </summary>
  public String? LanguageId
  {
    get => (System.String?)OpenXmlElement?.LanguageId?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.LanguageId != null)
        {
          if (value is not null)
            OpenXmlElement.LanguageId.Val = (System.String?)value;
          else
            OpenXmlElement.LanguageId = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.LanguageId = new DocumentFormat.OpenXml.Wordprocessing.LanguageId{ Val = (System.String?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Invalidated Field Cache.
  /// </summary>
  public Boolean? Dirty
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Dirty>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Dirty>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.Dirty();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}
