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
      return _Element?.GetObject<DMW.RunStyle,DXW.RunStyle>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.RunStyle,DXW.RunStyle>(value);
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
      return _Element?.GetObject<DMW.RunFonts,DXW.RunFonts>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.RunFonts,DXW.RunFonts>(value);
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
      return _Element?.GetObject<DMW.Bold,DXW.Bold>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Bold,DXW.Bold>(value);
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
      return _Element?.GetObject<DMW.BoldComplexScript,DXW.BoldComplexScript>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.BoldComplexScript,DXW.BoldComplexScript>(value);
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
      return _Element?.GetObject<DMW.Italic,DXW.Italic>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Italic,DXW.Italic>(value);
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
      return _Element?.GetObject<DMW.ItalicComplexScript,DXW.ItalicComplexScript>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.ItalicComplexScript,DXW.ItalicComplexScript>(value);
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
      return _Element?.GetObject<DMW.Caps,DXW.Caps>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Caps,DXW.Caps>(value);
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
      return _Element?.GetObject<DMW.SmallCaps,DXW.SmallCaps>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.SmallCaps,DXW.SmallCaps>(value);
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
      return _Element?.GetObject<DMW.Strike,DXW.Strike>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Strike,DXW.Strike>(value);
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
      return _Element?.GetObject<DMW.DoubleStrike,DXW.DoubleStrike>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DoubleStrike,DXW.DoubleStrike>(value);
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
      return _Element?.GetObject<DMW.Outline,DXW.Outline>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Outline,DXW.Outline>(value);
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
      return _Element?.GetObject<DMW.Shadow,DXW.Shadow>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Shadow,DXW.Shadow>(value);
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
      return _Element?.GetObject<DMW.Emboss,DXW.Emboss>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Emboss,DXW.Emboss>(value);
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
      return _Element?.GetObject<DMW.Imprint,DXW.Imprint>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Imprint,DXW.Imprint>(value);
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
      return _Element?.GetObject<DMW.NoProof,DXW.NoProof>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.NoProof,DXW.NoProof>(value);
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
      return _Element?.GetObject<DMW.SnapToGrid,DXW.SnapToGrid>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.SnapToGrid,DXW.SnapToGrid>(value);
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
      return _Element?.GetObject<DMW.Vanish,DXW.Vanish>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Vanish,DXW.Vanish>(value);
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
      return _Element?.GetObject<DMW.WebHidden,DXW.WebHidden>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.WebHidden,DXW.WebHidden>(value);
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
      return _Element?.GetObject<DMW.Color,DXW.Color>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Color,DXW.Color>(value);
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
      SimpleValueConverter.SetValue<DXW.Spacing,System.Int32>(_ExistingElement, value);
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
      SimpleValueConverter.SetValue<DXW.CharacterScale,System.Int64>(_ExistingElement, value);
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
      SimpleValueConverter.SetValue<DXW.Kern,System.UInt32>(_ExistingElement, value);
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
      StringValueConverter.SetValue<DXW.Position>(_ExistingElement, value);
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
      return _Element?.GetObject<DMW.FontSize,DXW.FontSize>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.FontSize,DXW.FontSize>(value);
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
      return _Element?.GetObject<DMW.FontSizeComplexScript,DXW.FontSizeComplexScript>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.FontSizeComplexScript,DXW.FontSizeComplexScript>(value);
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
      return _Element?.GetObject<DMW.Underline,DXW.Underline>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Underline,DXW.Underline>(value);
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
      return _Element?.GetObject<DMW.Border,DXW.Border>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Border,DXW.Border>(value);
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
      return _Element?.GetObject<DMW.Shading,DXW.Shading>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Shading,DXW.Shading>(value);
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
      return _Element?.GetObject<DMW.FitText,DXW.FitText>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.FitText,DXW.FitText>(value);
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
      return _Element?.GetObject<DMW.RightToLeftText,DXW.RightToLeftText>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.RightToLeftText,DXW.RightToLeftText>(value);
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
      return _Element?.GetObject<DMW.ComplexScript,DXW.ComplexScript>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.ComplexScript,DXW.ComplexScript>(value);
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
      return _Element?.GetObject<DMW.Languages,DXW.Languages>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Languages,DXW.Languages>(value);
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
      return _Element?.GetObject<DMW.EastAsianLayout,DXW.EastAsianLayout>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.EastAsianLayout,DXW.EastAsianLayout>(value);
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
      return _Element?.GetObject<DMW.SpecVanish,DXW.SpecVanish>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.SpecVanish,DXW.SpecVanish>(value);
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
      return _Element?.GetObject<DMW10.Glow,DXO10W.Glow>();
    }
    set
    {
      _ExistingElement.SetObject<DMW10.Glow,DXO10W.Glow>(value);
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
      return _Element?.GetObject<DMW10.Shadow,DXO10W.Shadow>();
    }
    set
    {
      _ExistingElement.SetObject<DMW10.Shadow,DXO10W.Shadow>(value);
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
      return _Element?.GetObject<DMW10.Reflection,DXO10W.Reflection>();
    }
    set
    {
      _ExistingElement.SetObject<DMW10.Reflection,DXO10W.Reflection>(value);
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
      return _Element?.GetObject<DMW10.TextOutlineEffect,DXO10W.TextOutlineEffect>();
    }
    set
    {
      _ExistingElement.SetObject<DMW10.TextOutlineEffect,DXO10W.TextOutlineEffect>(value);
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
      return _Element?.GetObject<DMW10.FillTextEffect,DXO10W.FillTextEffect>();
    }
    set
    {
      _ExistingElement.SetObject<DMW10.FillTextEffect,DXO10W.FillTextEffect>(value);
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
      return _Element?.GetObject<DMW10.Scene3D,DXO10W.Scene3D>();
    }
    set
    {
      _ExistingElement.SetObject<DMW10.Scene3D,DXO10W.Scene3D>(value);
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
      return _Element?.GetObject<DMW10.Properties3D,DXO10W.Properties3D>();
    }
    set
    {
      _ExistingElement.SetObject<DMW10.Properties3D,DXO10W.Properties3D>(value);
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
      return _Element?.GetObject<DMW10.StylisticSets,DXO10W.StylisticSets>();
    }
    set
    {
      _ExistingElement.SetObject<DMW10.StylisticSets,DXO10W.StylisticSets>(value);
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
      return _Element?.GetObject<DMW10.ContextualAlternatives,DXO10W.ContextualAlternatives>();
    }
    set
    {
      _ExistingElement.SetObject<DMW10.ContextualAlternatives,DXO10W.ContextualAlternatives>(value);
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
      return _Element?.GetObject<DMW.RunPropertiesChange,DXW.RunPropertiesChange>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.RunPropertiesChange,DXW.RunPropertiesChange>(value);
    }
  }
  
}
