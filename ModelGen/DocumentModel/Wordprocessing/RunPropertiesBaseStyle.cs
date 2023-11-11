namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of run properties applied to the glyph used to represent the physical location of the paragraph mark for this paragraph. This paragraph mark, being a physical character in the document, can be formatted, and therefore shall be capable of representing this formatting like any other character in the document.
/// </summary>
public partial class RunPropertiesBaseStyle: ModelElement<DXW.RunPropertiesBaseStyle>
{
  public RunPropertiesBaseStyle(): base(){ }
  
  public RunPropertiesBaseStyle(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RunPropertiesBaseStyle(DXW.RunPropertiesBaseStyle openXmlElement): base(openXmlElement) { }
  
  
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
  
}
