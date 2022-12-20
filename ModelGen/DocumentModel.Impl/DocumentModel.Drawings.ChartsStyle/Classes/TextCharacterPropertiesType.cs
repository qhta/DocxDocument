namespace DocumentModel.Drawings.ChartsStyle;

/// <summary>
/// Defines the TextCharacterPropertiesType Class.
/// </summary>
public partial class TextCharacterPropertiesTypeImpl: ModelElementImpl, TextCharacterPropertiesType
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public TextCharacterPropertiesTypeImpl(): base() {}
  
  public TextCharacterPropertiesTypeImpl(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  public Boolean? SmtClean
  {
    get => (System.Boolean?)OpenXmlElement?.SmtClean?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SmtClean = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Gets or sets the  value. It is only available for backwards compatibility
  /// </summary>
  public UInt32? SmtId
  {
    get => (System.UInt32?)OpenXmlElement?.SmtId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SmtId = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// kumimoji
  /// </summary>
  public Boolean? Kumimoji
  {
    get => (System.Boolean?)OpenXmlElement?.Kumimoji?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Kumimoji = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// lang
  /// </summary>
  public String? Language
  {
    get => (System.String?)OpenXmlElement?.Language?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Language = (System.String?)value;
    }
  }
  
  /// <summary>
  /// altLang
  /// </summary>
  public String? AlternativeLanguage
  {
    get => (System.String?)OpenXmlElement?.AlternativeLanguage?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AlternativeLanguage = (System.String?)value;
    }
  }
  
  /// <summary>
  /// sz
  /// </summary>
  public Int32? FontSize
  {
    get => (System.Int32?)OpenXmlElement?.FontSize?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FontSize = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// b
  /// </summary>
  public Boolean? Bold
  {
    get => (System.Boolean?)OpenXmlElement?.Bold?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Bold = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// i
  /// </summary>
  public Boolean? Italic
  {
    get => (System.Boolean?)OpenXmlElement?.Italic?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Italic = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// u
  /// </summary>
  public DocumentModel.Drawings.TextUnderlineKind? Underline
  {
    get => (DocumentModel.Drawings.TextUnderlineKind?)OpenXmlElement?.Underline?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Underline = (DocumentFormat.OpenXml.Drawing.TextUnderlineValues?)value;
    }
  }
  
  /// <summary>
  /// strike
  /// </summary>
  public DocumentModel.Drawings.TextStrikeKind? Strike
  {
    get => (DocumentModel.Drawings.TextStrikeKind?)OpenXmlElement?.Strike?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Strike = (DocumentFormat.OpenXml.Drawing.TextStrikeValues?)value;
    }
  }
  
  /// <summary>
  /// kern
  /// </summary>
  public Int32? Kerning
  {
    get => (System.Int32?)OpenXmlElement?.Kerning?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Kerning = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// cap
  /// </summary>
  public DocumentModel.Drawings.TextCapsKind? Capital
  {
    get => (DocumentModel.Drawings.TextCapsKind?)OpenXmlElement?.Capital?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Capital = (DocumentFormat.OpenXml.Drawing.TextCapsValues?)value;
    }
  }
  
  /// <summary>
  /// spc
  /// </summary>
  public Int32? Spacing
  {
    get => (System.Int32?)OpenXmlElement?.Spacing?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Spacing = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// normalizeH
  /// </summary>
  public Boolean? NormalizeHeight
  {
    get => (System.Boolean?)OpenXmlElement?.NormalizeHeight?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.NormalizeHeight = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// baseline
  /// </summary>
  public Int32? Baseline
  {
    get => (System.Int32?)OpenXmlElement?.Baseline?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Baseline = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// noProof
  /// </summary>
  public Boolean? NoProof
  {
    get => (System.Boolean?)OpenXmlElement?.NoProof?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.NoProof = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// dirty
  /// </summary>
  public Boolean? Dirty
  {
    get => (System.Boolean?)OpenXmlElement?.Dirty?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Dirty = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// err
  /// </summary>
  public Boolean? SpellingError
  {
    get => (System.Boolean?)OpenXmlElement?.SpellingError?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SpellingError = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// smtClean
  /// </summary>
  public Boolean? SmartTagClean
  {
    get => (System.Boolean?)OpenXmlElement?.SmartTagClean?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SmartTagClean = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// smtId
  /// </summary>
  public UInt32? SmartTagId
  {
    get => (System.UInt32?)OpenXmlElement?.SmartTagId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SmartTagId = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// bmk
  /// </summary>
  public String? Bookmark
  {
    get => (System.String?)OpenXmlElement?.Bookmark?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Bookmark = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Outline.
  /// </summary>
  public DocumentModel.Drawings.Outline? Outline
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Outline>();
        if (item != null)
          return new DocumentModel.Drawings.OutlineImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Outline>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.OutlineImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public Boolean? NoFill
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NoFill>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NoFill>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Drawing.NoFill();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public DocumentModel.Drawings.SolidFill? SolidFill
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SolidFill>();
        if (item != null)
          return new DocumentModel.Drawings.SolidFillImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SolidFill>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.SolidFillImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.GradientFill? GradientFill
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.GradientFill>();
        if (item != null)
          return new DocumentModel.Drawings.GradientFillImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.GradientFill>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.GradientFillImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.BlipFill? BlipFill
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BlipFill>();
        if (item != null)
          return new DocumentModel.Drawings.BlipFillImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BlipFill>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.BlipFillImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.PatternFill? PatternFill
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PatternFill>();
        if (item != null)
          return new DocumentModel.Drawings.PatternFillImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PatternFill>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.PatternFillImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public Boolean? GroupFill
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.GroupFill>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.GroupFill>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Drawing.GroupFill();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public DocumentModel.Drawings.EffectList? EffectList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectList>();
        if (item != null)
          return new DocumentModel.Drawings.EffectListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.EffectListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.EffectDag? EffectDag
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectDag>();
        if (item != null)
          return new DocumentModel.Drawings.EffectDagImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectDag>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.EffectDagImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Highlight? Highlight
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Highlight>();
        if (item != null)
          return new DocumentModel.Drawings.HighlightImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Highlight>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.HighlightImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public Boolean? UnderlineFollowsText
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.UnderlineFollowsText>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.UnderlineFollowsText>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Drawing.UnderlineFollowsText();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public Boolean? UnderlineFillText
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.UnderlineFillText>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.UnderlineFillText>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Drawing.UnderlineFillText();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public DocumentModel.Drawings.UnderlineFill? UnderlineFill
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.UnderlineFill>();
        if (item != null)
          return new DocumentModel.Drawings.UnderlineFillImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.UnderlineFill>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.UnderlineFillImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.TextFontType? LatinFont
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.TextFontType>();
        if (item != null)
          return new DocumentModel.Drawings.TextFontTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.TextFontType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.TextFontTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.TextFontType? EastAsianFont
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.TextFontType>();
        if (item != null)
          return new DocumentModel.Drawings.TextFontTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.TextFontType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.TextFontTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.TextFontType? ComplexScriptFont
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.TextFontType>();
        if (item != null)
          return new DocumentModel.Drawings.TextFontTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.TextFontType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.TextFontTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.TextFontType? SymbolFont
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.TextFontType>();
        if (item != null)
          return new DocumentModel.Drawings.TextFontTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.TextFontType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.TextFontTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.HyperlinkOnClick? HyperlinkOnClick
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnClick>();
        if (item != null)
          return new DocumentModel.Drawings.HyperlinkOnClickImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnClick>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.HyperlinkOnClickImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.HyperlinkOnMouseOver? HyperlinkOnMouseOver
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnMouseOver>();
        if (item != null)
          return new DocumentModel.Drawings.HyperlinkOnMouseOverImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.HyperlinkOnMouseOver>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.HyperlinkOnMouseOverImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public Boolean? RightToLeft
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.RightToLeft>();
        return (System.Boolean?)item?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.RightToLeft>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Drawing.RightToLeft{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public DocumentModel.Drawings.ExtensionList? ExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.ExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
