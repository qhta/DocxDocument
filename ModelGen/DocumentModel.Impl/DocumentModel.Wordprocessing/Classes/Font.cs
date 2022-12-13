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
  
  public FontImpl(): base() {}
  
  public FontImpl(DocumentFormat.OpenXml.Wordprocessing.Font openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// name
  /// </summary>
  public String? Name
  {
    get => (System.String?)OpenXmlElement?.Name?.Value;
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
    get => (System.String?)OpenXmlElement?.AltName?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.AltName != null)
        {
          if (value is not null)
            OpenXmlElement.AltName.Val = (System.String?)value;
          else
            OpenXmlElement.AltName = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.AltName = new DocumentFormat.OpenXml.Wordprocessing.AltName{ Val = (System.String?)value };
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
  public DocumentModel.Wordprocessing.FontCharSet? FontCharSet
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// FontFamily.
  /// </summary>
  public DocumentModel.Wordprocessing.FontFamilyKind? FontFamily
  {
    get => (DocumentModel.Wordprocessing.FontFamilyKind?)OpenXmlElement?.FontFamily?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.FontFamily != null)
        {
          if (value is not null)
            OpenXmlElement.FontFamily.Val = (DocumentFormat.OpenXml.Wordprocessing.FontFamilyValues?)value;
          else
            OpenXmlElement.FontFamily = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.FontFamily = new DocumentFormat.OpenXml.Wordprocessing.FontFamily{ Val = (DocumentFormat.OpenXml.Wordprocessing.FontFamilyValues?)value };
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
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NotTrueType>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NotTrueType>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.NotTrueType();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Pitch.
  /// </summary>
  public DocumentModel.Wordprocessing.FontPitchKind? Pitch
  {
    get => (DocumentModel.Wordprocessing.FontPitchKind?)OpenXmlElement?.Pitch?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Pitch != null)
        {
          if (value is not null)
            OpenXmlElement.Pitch.Val = (DocumentFormat.OpenXml.Wordprocessing.FontPitchValues?)value;
          else
            OpenXmlElement.Pitch = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Pitch = new DocumentFormat.OpenXml.Wordprocessing.Pitch{ Val = (DocumentFormat.OpenXml.Wordprocessing.FontPitchValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// FontSignature.
  /// </summary>
  public DocumentModel.Wordprocessing.FontSignature? FontSignature
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// EmbedRegularFont.
  /// </summary>
  public DocumentModel.Wordprocessing.FontRelationshipType? EmbedRegularFont
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// EmbedBoldFont.
  /// </summary>
  public DocumentModel.Wordprocessing.FontRelationshipType? EmbedBoldFont
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// EmbedItalicFont.
  /// </summary>
  public DocumentModel.Wordprocessing.FontRelationshipType? EmbedItalicFont
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// EmbedBoldItalicFont.
  /// </summary>
  public DocumentModel.Wordprocessing.FontRelationshipType? EmbedBoldItalicFont
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
