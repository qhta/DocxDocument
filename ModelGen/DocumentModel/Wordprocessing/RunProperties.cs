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
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.String253Type");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.String253Type");
  }
  
  
  /// <summary>
  ///   RunFonts.
  /// </summary>
  [DataMember]
  public DMW.RunFonts? RunFonts
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Bold.
  /// </summary>
  [DataMember]
  public DMW.Bold? Bold
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
  
  /// <summary>
  ///   BoldComplexScript.
  /// </summary>
  [DataMember]
  public DMW.BoldComplexScript? BoldComplexScript
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
  
  /// <summary>
  ///   Italic.
  /// </summary>
  [DataMember]
  public DMW.Italic? Italic
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
  
  /// <summary>
  ///   ItalicComplexScript.
  /// </summary>
  [DataMember]
  public DMW.ItalicComplexScript? ItalicComplexScript
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
  
  /// <summary>
  ///   Caps.
  /// </summary>
  [DataMember]
  public DMW.Caps? Caps
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
  
  /// <summary>
  ///   SmallCaps.
  /// </summary>
  [DataMember]
  public DMW.SmallCaps? SmallCaps
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
  
  /// <summary>
  ///   Strike.
  /// </summary>
  [DataMember]
  public DMW.Strike? Strike
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
  
  /// <summary>
  ///   DoubleStrike.
  /// </summary>
  [DataMember]
  public DMW.DoubleStrike? DoubleStrike
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
  
  /// <summary>
  ///   Outline.
  /// </summary>
  [DataMember]
  public DMW.Outline? Outline
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
  
  /// <summary>
  ///   Shadow.
  /// </summary>
  [DataMember]
  public DMW.Shadow? Shadow
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
  
  /// <summary>
  ///   Emboss.
  /// </summary>
  [DataMember]
  public DMW.Emboss? Emboss
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
  
  /// <summary>
  ///   Imprint.
  /// </summary>
  [DataMember]
  public DMW.Imprint? Imprint
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
  
  /// <summary>
  ///   NoProof.
  /// </summary>
  [DataMember]
  public DMW.NoProof? NoProof
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
  
  /// <summary>
  ///   SnapToGrid.
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? SnapToGrid
  {
    get => _Element?.GetHexIntVal<DXW.SnapToGrid>();
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Vanish.
  /// </summary>
  [DataMember]
  public DMW.Vanish? Vanish
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
  
  /// <summary>
  ///   WebHidden.
  /// </summary>
  [DataMember]
  public DMW.WebHidden? WebHidden
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
  
  /// <summary>
  ///   Color.
  /// </summary>
  [DataMember]
  public DMW.Color? Color
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Spacing.
  /// </summary>
  [DataMember]
  public Int32? Spacing
  {
    get => _Element?.GetIntVal<Int32, DXW.Spacing>();
    set => _ExistingElement.SetIntVal<Int32, DXW.Spacing>(value);
  }
  
  
  /// <summary>
  ///   CharacterScale.
  /// </summary>
  [DataMember]
  public Int64? CharacterScale
  {
    get => _Element?.GetIntVal<Int64, DXW.CharacterScale>();
    set => _ExistingElement.SetIntVal<Int64, DXW.CharacterScale>(value);
  }
  
  
  /// <summary>
  ///   Kern.
  /// </summary>
  [DataMember]
  public UInt32? Kern
  {
    get => _Element?.GetIntVal<UInt32, DXW.Kern>();
    set => _ExistingElement.SetIntVal<UInt32, DXW.Kern>(value);
  }
  
  
  /// <summary>
  ///   Position.
  /// </summary>
  [DataMember]
  public String? Position
  {
    get => _Element?.GetStringVal<DXW.Position>();
    set => _ExistingElement.SetStringVal<DXW.Position>(value);
  }
  
  
  /// <summary>
  ///   FontSize.
  /// </summary>
  [DataMember]
  public DMW.FontSize? FontSize
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.HpsMeasureType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.HpsMeasureType");
  }
  
  
  /// <summary>
  ///   FontSizeComplexScript.
  /// </summary>
  [DataMember]
  public DMW.FontSizeComplexScript? FontSizeComplexScript
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.HpsMeasureType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.HpsMeasureType");
  }
  
  
  /// <summary>
  ///   Highlight.
  /// </summary>
  [DataMember]
  public DMW.HighlightColorKind? Highlight
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Underline.
  /// </summary>
  [DataMember]
  public DMW.Underline? Underline
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   TextEffect.
  /// </summary>
  [DataMember]
  public DMW.TextEffectKind? TextEffect
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Border.
  /// </summary>
  [DataMember]
  public DMW.Border? Border
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.BorderType");
  }
  
  
  /// <summary>
  ///   Shading.
  /// </summary>
  [DataMember]
  public DMW.Shading? Shading
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   FitText.
  /// </summary>
  [DataMember]
  public DMW.FitText? FitText
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   VerticalTextAlignment.
  /// </summary>
  [DataMember]
  public DMW.VerticalPositionKind? VerticalTextAlignment
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   RightToLeftText.
  /// </summary>
  [DataMember]
  public DMW.RightToLeftText? RightToLeftText
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
  
  /// <summary>
  ///   ComplexScript.
  /// </summary>
  [DataMember]
  public DMW.ComplexScript? ComplexScript
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
  
  /// <summary>
  ///   Emphasis.
  /// </summary>
  [DataMember]
  public DMW.EmphasisMarkKind? Emphasis
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Languages.
  /// </summary>
  [DataMember]
  public DMW.Languages? Languages
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.LanguageType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.LanguageType");
  }
  
  
  /// <summary>
  ///   EastAsianLayout.
  /// </summary>
  [DataMember]
  public DMW.EastAsianLayout? EastAsianLayout
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   SpecVanish.
  /// </summary>
  [DataMember]
  public DMW.SpecVanish? SpecVanish
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
  
  /// <summary>
  ///   Glow, this property is only available in Office 2010 and later..
  /// </summary>
  [DataMember]
  public DMW10.Glow? Glow
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Shadow14, this property is only available in Office 2010 and later..
  /// </summary>
  [DataMember]
  public DMW10.Shadow? Shadow14
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Reflection, this property is only available in Office 2010 and later..
  /// </summary>
  [DataMember]
  public DMW10.Reflection? Reflection
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   TextOutlineEffect, this property is only available in Office 2010 and later..
  /// </summary>
  [DataMember]
  public DMW10.TextOutlineEffect? TextOutlineEffect
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   FillTextEffect, this property is only available in Office 2010 and later..
  /// </summary>
  [DataMember]
  public DMW10.FillTextEffect? FillTextEffect
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Scene3D, this property is only available in Office 2010 and later..
  /// </summary>
  [DataMember]
  public DMW10.Scene3D? Scene3D
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Properties3D, this property is only available in Office 2010 and later..
  /// </summary>
  [DataMember]
  public DMW10.Properties3D? Properties3D
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Ligatures, this property is only available in Office 2010 and later..
  /// </summary>
  [DataMember]
  public DMW10.LigaturesKind? Ligatures
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   NumberingFormat, this property is only available in Office 2010 and later..
  /// </summary>
  [DataMember]
  public DMW10.NumberFormKind? NumberingFormat
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   NumberSpacing, this property is only available in Office 2010 and later..
  /// </summary>
  [DataMember]
  public DMW10.NumberSpacingKind? NumberSpacing
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   StylisticSets, this property is only available in Office 2010 and later..
  /// </summary>
  [DataMember]
  public DMW10.StylisticSets? StylisticSets
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   ContextualAlternatives, this property is only available in Office 2010 and later..
  /// </summary>
  [DataMember]
  public DMW10.ContextualAlternatives? ContextualAlternatives
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office2010.Word.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office2010.Word.OnOffType");
  }
  
  
  /// <summary>
  ///   RunPropertiesChange.
  /// </summary>
  [DataMember]
  public DMW.RunPropertiesChange? RunPropertiesChange
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
