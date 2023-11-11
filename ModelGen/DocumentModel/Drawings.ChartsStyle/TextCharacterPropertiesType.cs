namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the TextCharacterPropertiesType Class.
/// </summary>
public partial class TextCharacterPropertiesType: ModelElement<DXO13DCS.TextCharacterPropertiesType>
{
  public TextCharacterPropertiesType(): base(){ }
  
  public TextCharacterPropertiesType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextCharacterPropertiesType(DXO13DCS.TextCharacterPropertiesType openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public Boolean? SmtClean
  {
    get
    {
      return _Element?.SmtClean?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.SmtClean = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.SmtClean = null;
    }
  }
  
  [DataMember]
  public UInt32? SmtId
  {
    get
    {
      return _Element?.SmtId?.Value;
    }
    set
    {
      _ExistingElement.SmtId = value;
    }
  }
  
  
  /// <summary>
  ///   kumimoji
  /// </summary>
  [DataMember]
  public Boolean? Kumimoji
  {
    get
    {
      return _Element?.Kumimoji?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Kumimoji = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.Kumimoji = null;
    }
  }
  
  
  /// <summary>
  ///   lang
  /// </summary>
  [DataMember]
  public String? Language
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Language);
    }
    set
    {
      _ExistingElement.Language = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   altLang
  /// </summary>
  [DataMember]
  public String? AlternativeLanguage
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.AlternativeLanguage);
    }
    set
    {
      _ExistingElement.AlternativeLanguage = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   sz
  /// </summary>
  [DataMember]
  public Int32? FontSize
  {
    get
    {
      return _Element?.FontSize?.Value;
    }
    set
    {
      _ExistingElement.FontSize = value;
    }
  }
  
  
  /// <summary>
  ///   b
  /// </summary>
  [DataMember]
  public Boolean? Bold
  {
    get
    {
      return _Element?.Bold?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Bold = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.Bold = null;
    }
  }
  
  
  /// <summary>
  ///   i
  /// </summary>
  [DataMember]
  public Boolean? Italic
  {
    get
    {
      return _Element?.Italic?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Italic = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.Italic = null;
    }
  }
  
  
  /// <summary>
  ///   kern
  /// </summary>
  [DataMember]
  public Int32? Kerning
  {
    get
    {
      return _Element?.Kerning?.Value;
    }
    set
    {
      _ExistingElement.Kerning = value;
    }
  }
  
  
  /// <summary>
  ///   spc
  /// </summary>
  [DataMember]
  public Int32? Spacing
  {
    get
    {
      return _Element?.Spacing?.Value;
    }
    set
    {
      _ExistingElement.Spacing = value;
    }
  }
  
  
  /// <summary>
  ///   normalizeH
  /// </summary>
  [DataMember]
  public Boolean? NormalizeHeight
  {
    get
    {
      return _Element?.NormalizeHeight?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.NormalizeHeight = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.NormalizeHeight = null;
    }
  }
  
  
  /// <summary>
  ///   baseline
  /// </summary>
  [DataMember]
  public Int32? Baseline
  {
    get
    {
      return _Element?.Baseline?.Value;
    }
    set
    {
      _ExistingElement.Baseline = value;
    }
  }
  
  
  /// <summary>
  ///   noProof
  /// </summary>
  [DataMember]
  public Boolean? NoProof
  {
    get
    {
      return _Element?.NoProof?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.NoProof = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.NoProof = null;
    }
  }
  
  
  /// <summary>
  ///   dirty
  /// </summary>
  [DataMember]
  public Boolean? Dirty
  {
    get
    {
      return _Element?.Dirty?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Dirty = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.Dirty = null;
    }
  }
  
  
  /// <summary>
  ///   err
  /// </summary>
  [DataMember]
  public Boolean? SpellingError
  {
    get
    {
      return _Element?.SpellingError?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.SpellingError = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.SpellingError = null;
    }
  }
  
  
  /// <summary>
  ///   smtClean
  /// </summary>
  [DataMember]
  public Boolean? SmartTagClean
  {
    get
    {
      return _Element?.SmartTagClean?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.SmartTagClean = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.SmartTagClean = null;
    }
  }
  
  
  /// <summary>
  ///   smtId
  /// </summary>
  [DataMember]
  public UInt32? SmartTagId
  {
    get
    {
      return _Element?.SmartTagId?.Value;
    }
    set
    {
      _ExistingElement.SmartTagId = value;
    }
  }
  
  
  /// <summary>
  ///   bmk
  /// </summary>
  [DataMember]
  public String? Bookmark
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Bookmark);
    }
    set
    {
      _ExistingElement.Bookmark = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Outline.
  /// </summary>
  [DataMember]
  public DMD.Outline? Outline
  {
    get
    {
      return _Element?.GetObject<DMD.Outline,DXD.Outline>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Outline,DXD.Outline>(value);
    }
  }
  
  [DataMember]
  public DMD.NoFill? NoFill
  {
    get
    {
      return _Element?.GetObject<DMD.NoFill,DXD.NoFill>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.NoFill,DXD.NoFill>(value);
    }
  }
  
  [DataMember]
  public DMD.SolidFill? SolidFill
  {
    get
    {
      return _Element?.GetObject<DMD.SolidFill,DXD.SolidFill>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.SolidFill,DXD.SolidFill>(value);
    }
  }
  
  [DataMember]
  public DMD.GradientFill? GradientFill
  {
    get
    {
      return _Element?.GetObject<DMD.GradientFill,DXD.GradientFill>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.GradientFill,DXD.GradientFill>(value);
    }
  }
  
  [DataMember]
  public DMD.BlipFill? BlipFill
  {
    get
    {
      return _Element?.GetObject<DMD.BlipFill,DXD.BlipFill>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.BlipFill,DXD.BlipFill>(value);
    }
  }
  
  [DataMember]
  public DMD.PatternFill? PatternFill
  {
    get
    {
      return _Element?.GetObject<DMD.PatternFill,DXD.PatternFill>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.PatternFill,DXD.PatternFill>(value);
    }
  }
  
  [DataMember]
  public DMD.GroupFill? GroupFill
  {
    get
    {
      return _Element?.GetObject<DMD.GroupFill,DXD.GroupFill>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.GroupFill,DXD.GroupFill>(value);
    }
  }
  
  [DataMember]
  public DMD.EffectList? EffectList
  {
    get
    {
      return _Element?.GetObject<DMD.EffectList,DXD.EffectList>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.EffectList,DXD.EffectList>(value);
    }
  }
  
  [DataMember]
  public DMD.EffectDag? EffectDag
  {
    get
    {
      return _Element?.GetObject<DMD.EffectDag,DXD.EffectDag>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.EffectDag,DXD.EffectDag>(value);
    }
  }
  
  [DataMember]
  public DMD.Highlight? Highlight
  {
    get
    {
      return _Element?.GetObject<DMD.Highlight,DXD.Highlight>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Highlight,DXD.Highlight>(value);
    }
  }
  
  [DataMember]
  public DMD.UnderlineFollowsText? UnderlineFollowsText
  {
    get
    {
      return _Element?.GetObject<DMD.UnderlineFollowsText,DXD.UnderlineFollowsText>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.UnderlineFollowsText,DXD.UnderlineFollowsText>(value);
    }
  }
  
  [DataMember]
  public DMD.UnderlineFillText? UnderlineFillText
  {
    get
    {
      return _Element?.GetObject<DMD.UnderlineFillText,DXD.UnderlineFillText>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.UnderlineFillText,DXD.UnderlineFillText>(value);
    }
  }
  
  [DataMember]
  public DMD.UnderlineFill? UnderlineFill
  {
    get
    {
      return _Element?.GetObject<DMD.UnderlineFill,DXD.UnderlineFill>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.UnderlineFill,DXD.UnderlineFill>(value);
    }
  }
  
  [DataMember]
  public DMD.LatinFont? LatinFont
  {
    get
    {
      return _Element?.GetObject<DMD.LatinFont,DXD.LatinFont>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.LatinFont,DXD.LatinFont>(value);
    }
  }
  
  [DataMember]
  public DMD.EastAsianFont? EastAsianFont
  {
    get
    {
      return _Element?.GetObject<DMD.EastAsianFont,DXD.EastAsianFont>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.EastAsianFont,DXD.EastAsianFont>(value);
    }
  }
  
  [DataMember]
  public DMD.ComplexScriptFont? ComplexScriptFont
  {
    get
    {
      return _Element?.GetObject<DMD.ComplexScriptFont,DXD.ComplexScriptFont>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.ComplexScriptFont,DXD.ComplexScriptFont>(value);
    }
  }
  
  [DataMember]
  public DMD.SymbolFont? SymbolFont
  {
    get
    {
      return _Element?.GetObject<DMD.SymbolFont,DXD.SymbolFont>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.SymbolFont,DXD.SymbolFont>(value);
    }
  }
  
  [DataMember]
  public DMD.HyperlinkOnClick? HyperlinkOnClick
  {
    get
    {
      return _Element?.GetObject<DMD.HyperlinkOnClick,DXD.HyperlinkOnClick>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.HyperlinkOnClick,DXD.HyperlinkOnClick>(value);
    }
  }
  
  [DataMember]
  public DMD.HyperlinkOnMouseOver? HyperlinkOnMouseOver
  {
    get
    {
      return _Element?.GetObject<DMD.HyperlinkOnMouseOver,DXD.HyperlinkOnMouseOver>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.HyperlinkOnMouseOver,DXD.HyperlinkOnMouseOver>(value);
    }
  }
  
  [DataMember]
  public Boolean? RightToLeft
  {
    get
    {
      return _ExistingElement.GetFirstChild<DXD.RightToLeft>() != null;
    }
    set
    {
      if (value == false)
      {
        var itemElement = _ExistingElement.GetFirstChild<DXD.RightToLeft>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DXD.RightToLeft();
        _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.ExtensionList? ExtensionList
  {
    get
    {
      return _Element?.GetObject<DMD.ExtensionList,DXD.ExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.ExtensionList,DXD.ExtensionList>(value);
    }
  }
  
}
