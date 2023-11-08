namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a set of run properties which shall be applied to the contents of the parent run after all style formatting has been applied to the text. These properties are defined as direct formatting, since they are directly applied to the run and supersede any formatting from styles.
/// </summary>
public partial class RunProperties: ModelElement<DXW.RunProperties>
{
  public RunProperties(): base(){ }
  
  public RunProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RunProperties(DXW.RunProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   RunStyle.
  /// </summary>
  [DataMember]
  public DMW.RunStyle? RunStyle
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.RunStyle>();
      if (element != null)
        return RunStyleConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.RunStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RunStyleConverter.CreateOpenXmlElement<DXW.RunStyle>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   RunFonts.
  /// </summary>
  [DataMember]
  public DMW.RunFonts? RunFonts
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.RunFonts>();
      if (element != null)
        return RunFontsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.RunFonts>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RunFontsConverter.CreateOpenXmlElement<DXW.RunFonts>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Bold.
  /// </summary>
  [DataMember]
  public DMW.Bold? Bold
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.Bold>();
      if (element != null)
        return BoldConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Bold>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BoldConverter.CreateOpenXmlElement<DXW.Bold>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   BoldComplexScript.
  /// </summary>
  [DataMember]
  public DMW.BoldComplexScript? BoldComplexScript
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.BoldComplexScript>();
      if (element != null)
        return BoldComplexScriptConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.BoldComplexScript>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BoldComplexScriptConverter.CreateOpenXmlElement<DXW.BoldComplexScript>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Italic.
  /// </summary>
  [DataMember]
  public DMW.Italic? Italic
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.Italic>();
      if (element != null)
        return ItalicConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Italic>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ItalicConverter.CreateOpenXmlElement<DXW.Italic>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ItalicComplexScript.
  /// </summary>
  [DataMember]
  public DMW.ItalicComplexScript? ItalicComplexScript
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.ItalicComplexScript>();
      if (element != null)
        return ItalicComplexScriptConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.ItalicComplexScript>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ItalicComplexScriptConverter.CreateOpenXmlElement<DXW.ItalicComplexScript>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Caps.
  /// </summary>
  [DataMember]
  public DMW.Caps? Caps
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.Caps>();
      if (element != null)
        return CapsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Caps>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CapsConverter.CreateOpenXmlElement<DXW.Caps>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   SmallCaps.
  /// </summary>
  [DataMember]
  public DMW.SmallCaps? SmallCaps
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.SmallCaps>();
      if (element != null)
        return SmallCapsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.SmallCaps>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SmallCapsConverter.CreateOpenXmlElement<DXW.SmallCaps>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Strike.
  /// </summary>
  [DataMember]
  public DMW.Strike? Strike
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.Strike>();
      if (element != null)
        return StrikeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Strike>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StrikeConverter.CreateOpenXmlElement<DXW.Strike>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   DoubleStrike.
  /// </summary>
  [DataMember]
  public DMW.DoubleStrike? DoubleStrike
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.DoubleStrike>();
      if (element != null)
        return DoubleStrikeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DoubleStrike>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DoubleStrikeConverter.CreateOpenXmlElement<DXW.DoubleStrike>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Outline.
  /// </summary>
  [DataMember]
  public DMW.Outline? Outline
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.Outline>();
      if (element != null)
        return OutlineConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Outline>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OutlineConverter.CreateOpenXmlElement<DXW.Outline>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Shadow.
  /// </summary>
  [DataMember]
  public DMW.Shadow? Shadow
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.Shadow>();
      if (element != null)
        return ShadowConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Shadow>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShadowConverter.CreateOpenXmlElement<DXW.Shadow>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Emboss.
  /// </summary>
  [DataMember]
  public DMW.Emboss? Emboss
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.Emboss>();
      if (element != null)
        return EmbossConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Emboss>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EmbossConverter.CreateOpenXmlElement<DXW.Emboss>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Imprint.
  /// </summary>
  [DataMember]
  public DMW.Imprint? Imprint
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.Imprint>();
      if (element != null)
        return ImprintConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Imprint>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ImprintConverter.CreateOpenXmlElement<DXW.Imprint>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   NoProof.
  /// </summary>
  [DataMember]
  public DMW.NoProof? NoProof
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.NoProof>();
      if (element != null)
        return NoProofConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.NoProof>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NoProofConverter.CreateOpenXmlElement<DXW.NoProof>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   SnapToGrid.
  /// </summary>
  [DataMember]
  public DMW.SnapToGrid? SnapToGrid
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.SnapToGrid>();
      if (element != null)
        return SnapToGridConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.SnapToGrid>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SnapToGridConverter.CreateOpenXmlElement<DXW.SnapToGrid>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Vanish.
  /// </summary>
  [DataMember]
  public DMW.Vanish? Vanish
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.Vanish>();
      if (element != null)
        return VanishConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Vanish>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = VanishConverter.CreateOpenXmlElement<DXW.Vanish>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   WebHidden.
  /// </summary>
  [DataMember]
  public DMW.WebHidden? WebHidden
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.WebHidden>();
      if (element != null)
        return WebHiddenConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.WebHidden>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = WebHiddenConverter.CreateOpenXmlElement<DXW.WebHidden>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Color.
  /// </summary>
  [DataMember]
  public DMW.Color? Color
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.Color>();
      if (element != null)
        return ColorConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Color>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ColorConverter.CreateOpenXmlElement<DXW.Color>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Spacing.
  /// </summary>
  [DataMember]
  public Int32? Spacing
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXW.Spacing>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXW.Spacing,System.Int32>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   CharacterScale.
  /// </summary>
  [DataMember]
  public Int64? CharacterScale
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXW.CharacterScale>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXW.CharacterScale,System.Int64>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   Kern.
  /// </summary>
  [DataMember]
  public UInt32? Kern
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXW.Kern>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXW.Kern,System.UInt32>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   Position.
  /// </summary>
  [DataMember]
  public String? Position
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetFirstChild<DXW.Position>()?.Val);
    }
    set
    {
      StringValueConverter.SetValue<DXW.Position>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   FontSize.
  /// </summary>
  [DataMember]
  public DMW.FontSize? FontSize
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.FontSize>();
      if (element != null)
        return FontSizeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.FontSize>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FontSizeConverter.CreateOpenXmlElement<DXW.FontSize>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   FontSizeComplexScript.
  /// </summary>
  [DataMember]
  public DMW.FontSizeComplexScript? FontSizeComplexScript
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.FontSizeComplexScript>();
      if (element != null)
        return FontSizeComplexScriptConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.FontSizeComplexScript>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FontSizeComplexScriptConverter.CreateOpenXmlElement<DXW.FontSizeComplexScript>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Highlight.
  /// </summary>
  [DataMember]
  public DMW.HighlightColorKind? Highlight
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.HighlightColorValues, DMW.HighlightColorKind>(_ExistingElement.GetFirstChild<DXW.Highlight>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Highlight>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.HighlightColorValues, DMW.HighlightColorKind>(itemElement, (DMW.HighlightColorKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.Highlight, DocumentFormat.OpenXml.Wordprocessing.HighlightColorValues, DMW.HighlightColorKind>((DMW.HighlightColorKind)value));
    }
  }
  
  
  /// <summary>
  ///   Underline.
  /// </summary>
  [DataMember]
  public DMW.Underline? Underline
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.Underline>();
      if (element != null)
        return UnderlineConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Underline>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = UnderlineConverter.CreateOpenXmlElement<DXW.Underline>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   TextEffect.
  /// </summary>
  [DataMember]
  public DMW.TextEffectKind? TextEffect
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TextEffectValues, DMW.TextEffectKind>(_ExistingElement.GetFirstChild<DXW.TextEffect>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TextEffect>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TextEffectValues, DMW.TextEffectKind>(itemElement, (DMW.TextEffectKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.TextEffect, DocumentFormat.OpenXml.Wordprocessing.TextEffectValues, DMW.TextEffectKind>((DMW.TextEffectKind)value));
    }
  }
  
  
  /// <summary>
  ///   Border.
  /// </summary>
  [DataMember]
  public DMW.Border? Border
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.Border>();
      if (element != null)
        return BorderConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Border>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BorderConverter.CreateOpenXmlElement<DXW.Border>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Shading.
  /// </summary>
  [DataMember]
  public DMW.Shading? Shading
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.Shading>();
      if (element != null)
        return ShadingConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Shading>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShadingConverter.CreateOpenXmlElement<DXW.Shading>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   FitText.
  /// </summary>
  [DataMember]
  public DMW.FitText? FitText
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.FitText>();
      if (element != null)
        return FitTextConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.FitText>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FitTextConverter.CreateOpenXmlElement<DXW.FitText>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   VerticalTextAlignment.
  /// </summary>
  [DataMember]
  public DMW.VerticalPositionKind? VerticalTextAlignment
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.VerticalPositionValues, DMW.VerticalPositionKind>(_ExistingElement.GetFirstChild<DXW.VerticalTextAlignment>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.VerticalTextAlignment>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.VerticalPositionValues, DMW.VerticalPositionKind>(itemElement, (DMW.VerticalPositionKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.VerticalTextAlignment, DocumentFormat.OpenXml.Wordprocessing.VerticalPositionValues, DMW.VerticalPositionKind>((DMW.VerticalPositionKind)value));
    }
  }
  
  
  /// <summary>
  ///   RightToLeftText.
  /// </summary>
  [DataMember]
  public DMW.RightToLeftText? RightToLeftText
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.RightToLeftText>();
      if (element != null)
        return RightToLeftTextConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.RightToLeftText>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RightToLeftTextConverter.CreateOpenXmlElement<DXW.RightToLeftText>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ComplexScript.
  /// </summary>
  [DataMember]
  public DMW.ComplexScript? ComplexScript
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.ComplexScript>();
      if (element != null)
        return ComplexScriptConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.ComplexScript>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ComplexScriptConverter.CreateOpenXmlElement<DXW.ComplexScript>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Emphasis.
  /// </summary>
  [DataMember]
  public DMW.EmphasisMarkKind? Emphasis
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.EmphasisMarkValues, DMW.EmphasisMarkKind>(_ExistingElement.GetFirstChild<DXW.Emphasis>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Emphasis>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.EmphasisMarkValues, DMW.EmphasisMarkKind>(itemElement, (DMW.EmphasisMarkKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.Emphasis, DocumentFormat.OpenXml.Wordprocessing.EmphasisMarkValues, DMW.EmphasisMarkKind>((DMW.EmphasisMarkKind)value));
    }
  }
  
  
  /// <summary>
  ///   Languages.
  /// </summary>
  [DataMember]
  public DMW.Languages? Languages
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.Languages>();
      if (element != null)
        return LanguagesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Languages>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LanguagesConverter.CreateOpenXmlElement<DXW.Languages>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   EastAsianLayout.
  /// </summary>
  [DataMember]
  public DMW.EastAsianLayout? EastAsianLayout
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.EastAsianLayout>();
      if (element != null)
        return EastAsianLayoutConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.EastAsianLayout>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EastAsianLayoutConverter.CreateOpenXmlElement<DXW.EastAsianLayout>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   SpecVanish.
  /// </summary>
  [DataMember]
  public DMW.SpecVanish? SpecVanish
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.SpecVanish>();
      if (element != null)
        return SpecVanishConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.SpecVanish>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SpecVanishConverter.CreateOpenXmlElement<DXW.SpecVanish>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Glow, this property is only available in Office 2010 and later..
  /// </summary>
  [DataMember]
  public DMW10.Glow? Glow
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10W.Glow>();
      if (element != null)
        return GlowConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10W.Glow>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GlowConverter.CreateOpenXmlElement<DXO10W.Glow>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Shadow14, this property is only available in Office 2010 and later..
  /// </summary>
  [DataMember]
  public DMW10.Shadow? Shadow14
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10W.Shadow>();
      if (element != null)
        return ShadowConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10W.Shadow>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShadowConverter.CreateOpenXmlElement<DXO10W.Shadow>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Reflection, this property is only available in Office 2010 and later..
  /// </summary>
  [DataMember]
  public DMW10.Reflection? Reflection
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10W.Reflection>();
      if (element != null)
        return ReflectionConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10W.Reflection>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ReflectionConverter.CreateOpenXmlElement<DXO10W.Reflection>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   TextOutlineEffect, this property is only available in Office 2010 and later..
  /// </summary>
  [DataMember]
  public DMW10.TextOutlineEffect? TextOutlineEffect
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10W.TextOutlineEffect>();
      if (element != null)
        return TextOutlineEffectConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10W.TextOutlineEffect>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextOutlineEffectConverter.CreateOpenXmlElement<DXO10W.TextOutlineEffect>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   FillTextEffect, this property is only available in Office 2010 and later..
  /// </summary>
  [DataMember]
  public DMW10.FillTextEffect? FillTextEffect
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10W.FillTextEffect>();
      if (element != null)
        return FillTextEffectConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10W.FillTextEffect>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FillTextEffectConverter.CreateOpenXmlElement<DXO10W.FillTextEffect>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Scene3D, this property is only available in Office 2010 and later..
  /// </summary>
  [DataMember]
  public DMW10.Scene3D? Scene3D
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10W.Scene3D>();
      if (element != null)
        return Scene3DConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10W.Scene3D>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Scene3DConverter.CreateOpenXmlElement<DXO10W.Scene3D>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Properties3D, this property is only available in Office 2010 and later..
  /// </summary>
  [DataMember]
  public DMW10.Properties3D? Properties3D
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10W.Properties3D>();
      if (element != null)
        return Properties3DConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10W.Properties3D>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Properties3DConverter.CreateOpenXmlElement<DXO10W.Properties3D>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Ligatures, this property is only available in Office 2010 and later..
  /// </summary>
  [DataMember]
  public DMW10.LigaturesKind? Ligatures
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.LigaturesValues, DMW10.LigaturesKind>(_ExistingElement.GetFirstChild<DXO10W.Ligatures>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10W.Ligatures>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.LigaturesValues, DMW10.LigaturesKind>(itemElement, (DMW10.LigaturesKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXO10W.Ligatures, DocumentFormat.OpenXml.Office2010.Word.LigaturesValues, DMW10.LigaturesKind>((DMW10.LigaturesKind)value));
    }
  }
  
  
  /// <summary>
  ///   NumberingFormat, this property is only available in Office 2010 and later..
  /// </summary>
  [DataMember]
  public DMW10.NumberFormKind? NumberingFormat
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.NumberFormValues, DMW10.NumberFormKind>(_ExistingElement.GetFirstChild<DXO10W.NumberingFormat>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10W.NumberingFormat>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.NumberFormValues, DMW10.NumberFormKind>(itemElement, (DMW10.NumberFormKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXO10W.NumberingFormat, DocumentFormat.OpenXml.Office2010.Word.NumberFormValues, DMW10.NumberFormKind>((DMW10.NumberFormKind)value));
    }
  }
  
  
  /// <summary>
  ///   NumberSpacing, this property is only available in Office 2010 and later..
  /// </summary>
  [DataMember]
  public DMW10.NumberSpacingKind? NumberSpacing
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.NumberSpacingValues, DMW10.NumberSpacingKind>(_ExistingElement.GetFirstChild<DXO10W.NumberSpacing>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10W.NumberSpacing>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.NumberSpacingValues, DMW10.NumberSpacingKind>(itemElement, (DMW10.NumberSpacingKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXO10W.NumberSpacing, DocumentFormat.OpenXml.Office2010.Word.NumberSpacingValues, DMW10.NumberSpacingKind>((DMW10.NumberSpacingKind)value));
    }
  }
  
  
  /// <summary>
  ///   StylisticSets, this property is only available in Office 2010 and later..
  /// </summary>
  [DataMember]
  public DMW10.StylisticSets? StylisticSets
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10W.StylisticSets>();
      if (element != null)
        return StylisticSetsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10W.StylisticSets>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StylisticSetsConverter.CreateOpenXmlElement<DXO10W.StylisticSets>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ContextualAlternatives, this property is only available in Office 2010 and later..
  /// </summary>
  [DataMember]
  public DMW10.ContextualAlternatives? ContextualAlternatives
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10W.ContextualAlternatives>();
      if (element != null)
        return ContextualAlternativesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10W.ContextualAlternatives>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ContextualAlternativesConverter.CreateOpenXmlElement<DXO10W.ContextualAlternatives>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   RunPropertiesChange.
  /// </summary>
  [DataMember]
  public DMW.RunPropertiesChange? RunPropertiesChange
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.RunPropertiesChange>();
      if (element != null)
        return RunPropertiesChangeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.RunPropertiesChange>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RunPropertiesChangeConverter.CreateOpenXmlElement<DXW.RunPropertiesChange>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
