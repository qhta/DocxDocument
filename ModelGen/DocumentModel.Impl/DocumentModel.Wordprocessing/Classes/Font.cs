namespace DocumentModel.Wordprocessing;

/// <summary>
/// Properties for a Single Font.
/// </summary>
public partial class FontImpl: ModelElementImpl, Font
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
  public DocumentModel.HexBinary? Panose1Number
  {
    get
    {
      if (OpenXmlElement?.Panose1Number?.Val?.Value != null)
        return (DocumentModel.HexBinary)OpenXmlElement.Panose1Number.Val.Value;
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value != null)
          OpenXmlElement.Panose1Number = new DocumentFormat.OpenXml.Wordprocessing.Panose1Number{ Val = value.ToString() };
        else
          OpenXmlElement.Panose1Number = null;
      }
    }
  }
  
  /// <summary>
  /// FontCharSet.
  /// </summary>
  public DocumentModel.Wordprocessing.FontCharSet? FontCharSet
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FontCharSet>();
        if (item != null)
          return new DocumentModel.Wordprocessing.FontCharSetImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FontCharSet>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.FontCharSetImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
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
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FontSignature>();
        if (item != null)
          return new DocumentModel.Wordprocessing.FontSignatureImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FontSignature>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.FontSignatureImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// EmbedRegularFont.
  /// </summary>
  public DocumentModel.Wordprocessing.FontRelationshipType? EmbedRegularFont
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FontRelationshipType>();
        if (item != null)
          return new DocumentModel.Wordprocessing.FontRelationshipTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FontRelationshipType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.FontRelationshipTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// EmbedBoldFont.
  /// </summary>
  public DocumentModel.Wordprocessing.FontRelationshipType? EmbedBoldFont
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FontRelationshipType>();
        if (item != null)
          return new DocumentModel.Wordprocessing.FontRelationshipTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FontRelationshipType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.FontRelationshipTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// EmbedItalicFont.
  /// </summary>
  public DocumentModel.Wordprocessing.FontRelationshipType? EmbedItalicFont
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FontRelationshipType>();
        if (item != null)
          return new DocumentModel.Wordprocessing.FontRelationshipTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FontRelationshipType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.FontRelationshipTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// EmbedBoldItalicFont.
  /// </summary>
  public DocumentModel.Wordprocessing.FontRelationshipType? EmbedBoldItalicFont
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FontRelationshipType>();
        if (item != null)
          return new DocumentModel.Wordprocessing.FontRelationshipTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FontRelationshipType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.FontRelationshipTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
