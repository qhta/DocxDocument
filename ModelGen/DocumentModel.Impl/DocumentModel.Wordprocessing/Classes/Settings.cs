namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Settings.
/// </summary>
public class SettingsImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.Settings>, Settings
{
  /// <summary>
  /// Write Protection.
  /// </summary>
  public WriteProtection? WriteProtection
  {
    get;
    set;
  }
  
  /// <summary>
  /// Document View Setting.
  /// </summary>
  public ViewKind? View
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.View>();
        return (ViewKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.View>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.ViewValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.View{ Val = (DocumentFormat.OpenXml.Wordprocessing.ViewValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Magnification Setting.
  /// </summary>
  public Zoom? Zoom
  {
    get;
    set;
  }
  
  public ProofState? ProofState
  {
    get;
    set;
  }
  
  public StylePaneFormatFilter? StylePaneFormatFilter
  {
    get;
    set;
  }
  
  public DocumentKind? DocumentType
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocumentType>();
        return (DocumentKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocumentType>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.DocumentTypeValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.DocumentType{ Val = (DocumentFormat.OpenXml.Wordprocessing.DocumentTypeValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  public MailMerge? MailMerge
  {
    get;
    set;
  }
  
  public RevisionView? RevisionView
  {
    get;
    set;
  }
  
  public DocumentProtection? DocumentProtection
  {
    get;
    set;
  }
  
  public CharacterSpacingKind? CharacterSpacingControl
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CharacterSpacingControl>();
        return (CharacterSpacingKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.CharacterSpacingControl>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.CharacterSpacingValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.CharacterSpacingControl{ Val = (DocumentFormat.OpenXml.Wordprocessing.CharacterSpacingValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  public NoLineBreaksAfterKinsoku? NoLineBreaksAfterKinsoku
  {
    get;
    set;
  }
  
  public NoLineBreaksBeforeKinsoku? NoLineBreaksBeforeKinsoku
  {
    get;
    set;
  }
  
  public SaveThroughXslt? SaveThroughXslt
  {
    get;
    set;
  }
  
  public HeaderShapeDefaults? HeaderShapeDefaults
  {
    get;
    set;
  }
  
  public FootnoteDocumentWideProperties? FootnoteDocumentWideProperties
  {
    get;
    set;
  }
  
  public EndnoteDocumentWideProperties? EndnoteDocumentWideProperties
  {
    get;
    set;
  }
  
  public Compatibility? Compatibility
  {
    get;
    set;
  }
  
  public DocumentVariables? DocumentVariables
  {
    get;
    set;
  }
  
  public Rsids? Rsids
  {
    get;
    set;
  }
  
  public DocumentModel.Math.MathProperties? MathProperties
  {
    get;
    set;
  }
  
  public ColorSchemeMapping? ColorSchemeMapping
  {
    get;
    set;
  }
  
  public Captions? Captions
  {
    get;
    set;
  }
  
  public ReadModeInkLockDown? ReadModeInkLockDown
  {
    get;
    set;
  }
  
  public DocumentModel.CustomXml.SchemaLibrary? SchemaLibrary
  {
    get;
    set;
  }
  
  public ShapeDefaults? ShapeDefaults
  {
    get;
    set;
  }
  
  public OnOffKind? DiscardImageEditingData
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.DiscardImageEditingData>();
        return (OnOffKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.DiscardImageEditingData>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Office2010.Word.OnOffValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Office2010.Word.DiscardImageEditingData{ Val = (DocumentFormat.OpenXml.Office2010.Word.OnOffValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  public OnOffKind? ConflictMode
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.ConflictMode>();
        return (OnOffKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.ConflictMode>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Office2010.Word.OnOffValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Office2010.Word.ConflictMode{ Val = (DocumentFormat.OpenXml.Office2010.Word.OnOffValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
}
