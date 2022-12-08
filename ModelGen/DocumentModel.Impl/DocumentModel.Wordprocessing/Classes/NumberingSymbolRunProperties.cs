namespace DocumentModel.Wordprocessing;

/// <summary>
/// Numbering Symbol Run Properties.
/// </summary>
public class NumberingSymbolRunPropertiesImpl: ModelElementImpl, NumberingSymbolRunProperties
{
  public DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.NumberingSymbolRunProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// RunFonts.
  /// </summary>
  public RunFonts? RunFonts
  {
    get;
    set;
  }
  
  /// <summary>
  /// Bold.
  /// </summary>
  public Boolean? Bold
  {
    get;
    set;
  }
  
  /// <summary>
  /// BoldComplexScript.
  /// </summary>
  public Boolean? BoldComplexScript
  {
    get;
    set;
  }
  
  /// <summary>
  /// Italic.
  /// </summary>
  public Boolean? Italic
  {
    get;
    set;
  }
  
  /// <summary>
  /// ItalicComplexScript.
  /// </summary>
  public Boolean? ItalicComplexScript
  {
    get;
    set;
  }
  
  /// <summary>
  /// Caps.
  /// </summary>
  public Boolean? Caps
  {
    get;
    set;
  }
  
  /// <summary>
  /// SmallCaps.
  /// </summary>
  public Boolean? SmallCaps
  {
    get;
    set;
  }
  
  /// <summary>
  /// Strike.
  /// </summary>
  public Boolean? Strike
  {
    get;
    set;
  }
  
  /// <summary>
  /// DoubleStrike.
  /// </summary>
  public Boolean? DoubleStrike
  {
    get;
    set;
  }
  
  /// <summary>
  /// Outline.
  /// </summary>
  public Boolean? Outline
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shadow.
  /// </summary>
  public Boolean? Shadow
  {
    get;
    set;
  }
  
  /// <summary>
  /// Emboss.
  /// </summary>
  public Boolean? Emboss
  {
    get;
    set;
  }
  
  /// <summary>
  /// Imprint.
  /// </summary>
  public Boolean? Imprint
  {
    get;
    set;
  }
  
  /// <summary>
  /// NoProof.
  /// </summary>
  public Boolean? NoProof
  {
    get;
    set;
  }
  
  /// <summary>
  /// SnapToGrid.
  /// </summary>
  public Boolean? SnapToGrid
  {
    get;
    set;
  }
  
  /// <summary>
  /// Vanish.
  /// </summary>
  public Boolean? Vanish
  {
    get;
    set;
  }
  
  /// <summary>
  /// WebHidden.
  /// </summary>
  public Boolean? WebHidden
  {
    get;
    set;
  }
  
  /// <summary>
  /// Color.
  /// </summary>
  public Color? Color
  {
    get;
    set;
  }
  
  /// <summary>
  /// Spacing.
  /// </summary>
  public Int32? Spacing
  {
    get;
    set;
  }
  
  /// <summary>
  /// CharacterScale.
  /// </summary>
  public Int32? CharacterScale
  {
    get;
    set;
  }
  
  /// <summary>
  /// Kern.
  /// </summary>
  public UInt32? Kern
  {
    get;
    set;
  }
  
  /// <summary>
  /// Position.
  /// </summary>
  public String? Position
  {
    get;
    set;
  }
  
  /// <summary>
  /// FontSize.
  /// </summary>
  public String? FontSize
  {
    get;
    set;
  }
  
  /// <summary>
  /// FontSizeComplexScript.
  /// </summary>
  public String? FontSizeComplexScript
  {
    get;
    set;
  }
  
  /// <summary>
  /// Underline.
  /// </summary>
  public Underline? Underline
  {
    get;
    set;
  }
  
  /// <summary>
  /// TextEffect.
  /// </summary>
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
  
  /// <summary>
  /// Border.
  /// </summary>
  public BorderType? Border
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shading.
  /// </summary>
  public Shading? Shading
  {
    get;
    set;
  }
  
  /// <summary>
  /// FitText.
  /// </summary>
  public FitText? FitText
  {
    get;
    set;
  }
  
  /// <summary>
  /// VerticalTextAlignment.
  /// </summary>
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
  
  /// <summary>
  /// RightToLeftText.
  /// </summary>
  public Boolean? RightToLeftText
  {
    get;
    set;
  }
  
  /// <summary>
  /// ComplexScript.
  /// </summary>
  public Boolean? ComplexScript
  {
    get;
    set;
  }
  
  /// <summary>
  /// Emphasis.
  /// </summary>
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
  
  /// <summary>
  /// Languages.
  /// </summary>
  public LanguageType? Languages
  {
    get;
    set;
  }
  
  /// <summary>
  /// EastAsianLayout.
  /// </summary>
  public EastAsianLayout? EastAsianLayout
  {
    get;
    set;
  }
  
  /// <summary>
  /// SpecVanish.
  /// </summary>
  public Boolean? SpecVanish
  {
    get;
    set;
  }
  
}
