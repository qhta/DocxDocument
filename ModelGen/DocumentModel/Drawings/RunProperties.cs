namespace DocumentModel.Drawings;


/// <summary>
///   Text Run Properties.
/// </summary>
public partial class RunProperties: ModelElement<DXD.RunProperties>
{
  public RunProperties(): base(){ }
  
  public RunProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RunProperties(DXD.RunProperties openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMD.Outline? Outline
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.Outline>();
      if (element != null)
        return OutlineConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Outline>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OutlineConverter.CreateOpenXmlElement<DXD.Outline>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.NoFill? NoFill
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.NoFill>();
      if (element != null)
        return NoFillConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.NoFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NoFillConverter.CreateOpenXmlElement<DXD.NoFill>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.SolidFill? SolidFill
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.SolidFill>();
      if (element != null)
        return SolidFillConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.SolidFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SolidFillConverter.CreateOpenXmlElement<DXD.SolidFill>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.GradientFill? GradientFill
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.GradientFill>();
      if (element != null)
        return GradientFillConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.GradientFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GradientFillConverter.CreateOpenXmlElement<DXD.GradientFill>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.BlipFill? BlipFill
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.BlipFill>();
      if (element != null)
        return BlipFillConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.BlipFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BlipFillConverter.CreateOpenXmlElement<DXD.BlipFill>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.PatternFill? PatternFill
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.PatternFill>();
      if (element != null)
        return PatternFillConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.PatternFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PatternFillConverter.CreateOpenXmlElement<DXD.PatternFill>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.GroupFill? GroupFill
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.GroupFill>();
      if (element != null)
        return GroupFillConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.GroupFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GroupFillConverter.CreateOpenXmlElement<DXD.GroupFill>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.EffectList? EffectList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.EffectList>();
      if (element != null)
        return EffectListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.EffectList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EffectListConverter.CreateOpenXmlElement<DXD.EffectList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.EffectDag? EffectDag
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.EffectDag>();
      if (element != null)
        return EffectDagConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.EffectDag>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EffectDagConverter.CreateOpenXmlElement<DXD.EffectDag>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.Highlight? Highlight
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.Highlight>();
      if (element != null)
        return HighlightConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Highlight>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HighlightConverter.CreateOpenXmlElement<DXD.Highlight>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.UnderlineFollowsText? UnderlineFollowsText
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.UnderlineFollowsText>();
      if (element != null)
        return UnderlineFollowsTextConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.UnderlineFollowsText>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = UnderlineFollowsTextConverter.CreateOpenXmlElement<DXD.UnderlineFollowsText>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.Underline? Underline
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.Underline>();
      if (element != null)
        return UnderlineConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Underline>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = UnderlineConverter.CreateOpenXmlElement<DXD.Underline>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.UnderlineFillText? UnderlineFillText
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.UnderlineFillText>();
      if (element != null)
        return UnderlineFillTextConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.UnderlineFillText>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = UnderlineFillTextConverter.CreateOpenXmlElement<DXD.UnderlineFillText>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.UnderlineFill? UnderlineFill
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.UnderlineFill>();
      if (element != null)
        return UnderlineFillConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.UnderlineFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = UnderlineFillConverter.CreateOpenXmlElement<DXD.UnderlineFill>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.LatinFont? LatinFont
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.LatinFont>();
      if (element != null)
        return LatinFontConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.LatinFont>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LatinFontConverter.CreateOpenXmlElement<DXD.LatinFont>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.EastAsianFont? EastAsianFont
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.EastAsianFont>();
      if (element != null)
        return EastAsianFontConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.EastAsianFont>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EastAsianFontConverter.CreateOpenXmlElement<DXD.EastAsianFont>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.ComplexScriptFont? ComplexScriptFont
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.ComplexScriptFont>();
      if (element != null)
        return ComplexScriptFontConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.ComplexScriptFont>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ComplexScriptFontConverter.CreateOpenXmlElement<DXD.ComplexScriptFont>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.SymbolFont? SymbolFont
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.SymbolFont>();
      if (element != null)
        return SymbolFontConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.SymbolFont>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SymbolFontConverter.CreateOpenXmlElement<DXD.SymbolFont>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.HyperlinkOnClick? HyperlinkOnClick
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.HyperlinkOnClick>();
      if (element != null)
        return HyperlinkOnClickConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.HyperlinkOnClick>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HyperlinkOnClickConverter.CreateOpenXmlElement<DXD.HyperlinkOnClick>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.HyperlinkOnMouseOver? HyperlinkOnMouseOver
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.HyperlinkOnMouseOver>();
      if (element != null)
        return HyperlinkOnMouseOverConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.HyperlinkOnMouseOver>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HyperlinkOnMouseOverConverter.CreateOpenXmlElement<DXD.HyperlinkOnMouseOver>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.ExtensionList>();
      if (element != null)
        return ExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DXD.ExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
