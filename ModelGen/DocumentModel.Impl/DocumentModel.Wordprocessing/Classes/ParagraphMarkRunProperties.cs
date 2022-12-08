namespace DocumentModel.Wordprocessing;

/// <summary>
/// Run Properties for the Paragraph Mark.
/// </summary>
public class ParagraphMarkRunPropertiesImpl: ModelElementImpl, ParagraphMarkRunProperties
{
  public DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.ParagraphMarkRunProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Inserted Paragraph.
  /// </summary>
  public TrackChangeType? Inserted
  {
    get;
    set;
  }
  
  /// <summary>
  /// Deleted Paragraph.
  /// </summary>
  public TrackChangeType? Deleted
  {
    get;
    set;
  }
  
  /// <summary>
  /// Move Source Paragraph.
  /// </summary>
  public TrackChangeType? MoveFrom
  {
    get;
    set;
  }
  
  /// <summary>
  /// Move Destination Paragraph.
  /// </summary>
  public TrackChangeType? MoveTo
  {
    get;
    set;
  }
  
  public TrackChangeType? ConflictInsertion
  {
    get;
    set;
  }
  
  public TrackChangeType? ConflictDeletion
  {
    get;
    set;
  }
  
  public String? RunStyle
  {
    get;
    set;
  }
  
  public RunFonts? RunFonts
  {
    get;
    set;
  }
  
  public Boolean? Bold
  {
    get;
    set;
  }
  
  public Boolean? BoldComplexScript
  {
    get;
    set;
  }
  
  public Boolean? Italic
  {
    get;
    set;
  }
  
  public Boolean? ItalicComplexScript
  {
    get;
    set;
  }
  
  public Boolean? Caps
  {
    get;
    set;
  }
  
  public Boolean? SmallCaps
  {
    get;
    set;
  }
  
  public Boolean? Strike
  {
    get;
    set;
  }
  
  public Boolean? DoubleStrike
  {
    get;
    set;
  }
  
  public Boolean? Outline
  {
    get;
    set;
  }
  
  public Boolean? Shadow
  {
    get;
    set;
  }
  
  public Boolean? Emboss
  {
    get;
    set;
  }
  
  public Boolean? Imprint
  {
    get;
    set;
  }
  
  public Boolean? NoProof
  {
    get;
    set;
  }
  
  public Boolean? SnapToGrid
  {
    get;
    set;
  }
  
  public Boolean? Vanish
  {
    get;
    set;
  }
  
  public Boolean? WebHidden
  {
    get;
    set;
  }
  
  public Color? Color
  {
    get;
    set;
  }
  
  public Int32? Spacing
  {
    get;
    set;
  }
  
  public Int32? CharacterScale
  {
    get;
    set;
  }
  
  public UInt32? Kern
  {
    get;
    set;
  }
  
  public String? Position
  {
    get;
    set;
  }
  
  public String? FontSize
  {
    get;
    set;
  }
  
  public String? FontSizeComplexScript
  {
    get;
    set;
  }
  
  public HighlightColorKind? Highlight
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Highlight>();
        return (HighlightColorKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Highlight>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.HighlightColorValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.Highlight{ Val = (DocumentFormat.OpenXml.Wordprocessing.HighlightColorValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  public Underline? Underline
  {
    get;
    set;
  }
  
  public TextEffectKind? TextEffect
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TextEffect>();
        return (TextEffectKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TextEffect>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.TextEffectValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.TextEffect{ Val = (DocumentFormat.OpenXml.Wordprocessing.TextEffectValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  public BorderType? Border
  {
    get;
    set;
  }
  
  public Shading? Shading
  {
    get;
    set;
  }
  
  public FitText? FitText
  {
    get;
    set;
  }
  
  public VerticalPositionKind? VerticalTextAlignment
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignment>();
        return (VerticalPositionKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignment>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.VerticalPositionValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignment{ Val = (DocumentFormat.OpenXml.Wordprocessing.VerticalPositionValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  public Boolean? RightToLeftText
  {
    get;
    set;
  }
  
  public Boolean? ComplexScript
  {
    get;
    set;
  }
  
  public EmphasisMarkKind? Emphasis
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Emphasis>();
        return (EmphasisMarkKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Emphasis>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.EmphasisMarkValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.Emphasis{ Val = (DocumentFormat.OpenXml.Wordprocessing.EmphasisMarkValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  public LanguageType? Languages
  {
    get;
    set;
  }
  
  public EastAsianLayout? EastAsianLayout
  {
    get;
    set;
  }
  
  public Boolean? SpecVanish
  {
    get;
    set;
  }
  
  public Glow? Glow
  {
    get;
    set;
  }
  
  public Reflection? Reflection
  {
    get;
    set;
  }
  
  public TextOutlineEffect? TextOutlineEffect
  {
    get;
    set;
  }
  
  public FillTextEffect? FillTextEffect
  {
    get;
    set;
  }
  
  public Scene3D? Scene3D
  {
    get;
    set;
  }
  
  public Properties3D? Properties3D
  {
    get;
    set;
  }
  
  public LigaturesKind? Ligatures
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Ligatures>();
        return (LigaturesKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Ligatures>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Office2010.Word.LigaturesValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Office2010.Word.Ligatures{ Val = (DocumentFormat.OpenXml.Office2010.Word.LigaturesValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  public NumberFormKind? NumberingFormat
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.NumberingFormat>();
        return (NumberFormKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.NumberingFormat>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Office2010.Word.NumberFormValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Office2010.Word.NumberingFormat{ Val = (DocumentFormat.OpenXml.Office2010.Word.NumberFormValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  public NumberSpacingKind? NumberSpacing
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.NumberSpacing>();
        return (NumberSpacingKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.NumberSpacing>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Office2010.Word.NumberSpacingValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Office2010.Word.NumberSpacing{ Val = (DocumentFormat.OpenXml.Office2010.Word.NumberSpacingValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  public StylisticSets? StylisticSets
  {
    get;
    set;
  }
  
  public OnOffKind? ContextualAlternatives
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.ContextualAlternatives>();
        return (OnOffKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.ContextualAlternatives>();
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
            openXmlElement = new DocumentFormat.OpenXml.Office2010.Word.ContextualAlternatives{ Val = (DocumentFormat.OpenXml.Office2010.Word.OnOffValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  public Boolean? OfficeMath
  {
    get;
    set;
  }
  
  public ParagraphMarkRunPropertiesChange? ParagraphMarkRunPropertiesChange
  {
    get;
    set;
  }
  
}
