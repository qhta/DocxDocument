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
    get => (String?)OpenXmlElement?.Name?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Name = (System.String?)value;
    }
  }
  
  /// <summary>
  /// AltName.
  /// </summary>
  public String? AltName
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AltName>();
        return (String?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.AltName>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Val = (System.String?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.AltName{ Val = (System.String?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Panose1Number.
  /// </summary>
  public DocumentModel.HexBinaryValue? Panose1Number
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// FontCharSet.
  /// </summary>
  public FontCharSet? FontCharSet
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
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
          if (value is not null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.FontFamilyValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
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
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NotTrueType>();
        return (Boolean?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NotTrueType>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Val = (System.Boolean?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.NotTrueType{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
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
          if (value is not null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.FontPitchValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// EmbedRegularFont.
  /// </summary>
  public FontRelationshipType? EmbedRegularFont
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// EmbedBoldFont.
  /// </summary>
  public FontRelationshipType? EmbedBoldFont
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// EmbedItalicFont.
  /// </summary>
  public FontRelationshipType? EmbedItalicFont
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// EmbedBoldItalicFont.
  /// </summary>
  public FontRelationshipType? EmbedBoldItalicFont
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
