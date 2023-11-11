namespace DocumentModel.Drawings;


/// <summary>
///   Default Text Run Properties.
/// </summary>
public partial class DefaultRunProperties: ModelElement<DXD.DefaultRunProperties>
{
  public DefaultRunProperties(): base(){ }
  
  public DefaultRunProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DefaultRunProperties(DXD.DefaultRunProperties openXmlElement): base(openXmlElement) { }
  
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
  public DMD.Underline? Underline
  {
    get
    {
      return _Element?.GetObject<DMD.Underline,DXD.Underline>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Underline,DXD.Underline>(value);
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
