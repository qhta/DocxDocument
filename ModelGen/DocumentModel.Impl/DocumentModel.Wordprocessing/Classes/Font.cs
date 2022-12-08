namespace DocumentModel.Wordprocessing;

/// <summary>
/// Properties for a Single Font.
/// </summary>
public class FontImpl: ModelElementImpl, Font
{
  public DocumentFormat.OpenXml.Wordprocessing.Font? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Font?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// name
  /// </summary>
  public String? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// AltName.
  /// </summary>
  public String? AltName
  {
    get;
    set;
  }
  
  /// <summary>
  /// Panose1Number.
  /// </summary>
  public DocumentModel.HexBinaryValue? Panose1Number
  {
    get;
    set;
  }
  
  /// <summary>
  /// FontCharSet.
  /// </summary>
  public FontCharSet? FontCharSet
  {
    get;
    set;
  }
  
  /// <summary>
  /// FontFamily.
  /// </summary>
  public FontFamilyKind? FontFamily
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FontFamily>();
        return (FontFamilyKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FontFamily>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.FontFamilyValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.FontFamily{ Val = (DocumentFormat.OpenXml.Wordprocessing.FontFamilyValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// NotTrueType.
  /// </summary>
  public Boolean? NotTrueType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Pitch.
  /// </summary>
  public FontPitchKind? Pitch
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Pitch>();
        return (FontPitchKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Pitch>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.FontPitchValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.Pitch{ Val = (DocumentFormat.OpenXml.Wordprocessing.FontPitchValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// FontSignature.
  /// </summary>
  public FontSignature? FontSignature
  {
    get;
    set;
  }
  
  /// <summary>
  /// EmbedRegularFont.
  /// </summary>
  public FontRelationshipType? EmbedRegularFont
  {
    get;
    set;
  }
  
  /// <summary>
  /// EmbedBoldFont.
  /// </summary>
  public FontRelationshipType? EmbedBoldFont
  {
    get;
    set;
  }
  
  /// <summary>
  /// EmbedItalicFont.
  /// </summary>
  public FontRelationshipType? EmbedItalicFont
  {
    get;
    set;
  }
  
  /// <summary>
  /// EmbedBoldItalicFont.
  /// </summary>
  public FontRelationshipType? EmbedBoldItalicFont
  {
    get;
    set;
  }
  
}
