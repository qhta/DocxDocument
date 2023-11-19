namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the definition of a single style within a WordprocessingML document. A style is a predefined set of table, numbering, paragraph, and/or character properties which can be applied to regions within a document.
/// </summary>
public partial class Style: ModelElement<DXW.Style>
{
  public Style(): base(){ }
  
  public Style(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Style(DXW.Style openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Style ID
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? StyleId
  {
    get => HexIntConverter.GetValue(_Element?.StyleId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Default Style
  /// </summary>
  [DataMember]
  public Boolean? Default
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
  }
  
  
  /// <summary>
  ///   User-Defined Style
  /// </summary>
  [DataMember]
  public Boolean? CustomStyle
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
  }
  
  
  /// <summary>
  ///   Primary Style Name.
  /// </summary>
  [DataMember]
  public String? StyleName
  {
    get => _Element?.GetStringVal<DXW.StyleName>();
    set => _ExistingElement.SetStringVal<DXW.StyleName>(value);
  }
  
  
  /// <summary>
  ///   Alternate Style Names.
  /// </summary>
  [DataMember]
  public DMW.Aliases? Aliases
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.String253Type");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.String253Type");
  }
  
  
  /// <summary>
  ///   Parent Style ID.
  /// </summary>
  [DataMember]
  public DMW.BasedOn? BasedOn
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.String253Type");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.String253Type");
  }
  
  
  /// <summary>
  ///   Style For Next Paragraph.
  /// </summary>
  [DataMember]
  public DMW.NextParagraphStyle? NextParagraphStyle
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.String253Type");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.String253Type");
  }
  
  
  /// <summary>
  ///   Linked Style Reference.
  /// </summary>
  [DataMember]
  public DMW.LinkedStyle? LinkedStyle
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.String253Type");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.String253Type");
  }
  
  
  /// <summary>
  ///   Automatically Merge User Formatting Into Style Definition.
  /// </summary>
  [DataMember]
  public DMW.AutoRedefine? AutoRedefine
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyType");
  }
  
  
  /// <summary>
  ///   Hide Style From User Interface.
  /// </summary>
  [DataMember]
  public DMW.StyleHidden? StyleHidden
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyType");
  }
  
  
  /// <summary>
  ///   Optional User Interface Sorting Order.
  /// </summary>
  [DataMember]
  public Int32? UIPriority
  {
    get => _Element?.GetIntVal<Int32, DXW.UIPriority>();
    set => _ExistingElement.SetIntVal<Int32, DXW.UIPriority>(value);
  }
  
  
  /// <summary>
  ///   Hide Style From Main User Interface.
  /// </summary>
  [DataMember]
  public DMW.SemiHidden? SemiHidden
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyType");
  }
  
  
  /// <summary>
  ///   Remove Semi-Hidden Property When Style Is Used.
  /// </summary>
  [DataMember]
  public DMW.UnhideWhenUsed? UnhideWhenUsed
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyType");
  }
  
  
  /// <summary>
  ///   Primary Style.
  /// </summary>
  [DataMember]
  public DMW.PrimaryStyle? PrimaryStyle
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyType");
  }
  
  
  /// <summary>
  ///   Style Cannot Be Applied.
  /// </summary>
  [DataMember]
  public DMW.Locked? Locked
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyType");
  }
  
  
  /// <summary>
  ///   E-Mail Message Text Style.
  /// </summary>
  [DataMember]
  public DMW.Personal? Personal
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyType");
  }
  
  
  /// <summary>
  ///   E-Mail Message Composition Style.
  /// </summary>
  [DataMember]
  public DMW.PersonalCompose? PersonalCompose
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyType");
  }
  
  
  /// <summary>
  ///   E-Mail Message Reply Style.
  /// </summary>
  [DataMember]
  public DMW.PersonalReply? PersonalReply
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyType");
  }
  
  
  /// <summary>
  ///   Revision Identifier for Style Definition.
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? Rsid
  {
    get => _Element?.GetHexIntVal<DXW.Rsid>();
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Style Paragraph Properties.
  /// </summary>
  [DataMember]
  public DMW.StyleParagraphProperties? StyleParagraphProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Run Properties.
  /// </summary>
  [DataMember]
  public DMW.StyleRunProperties? StyleRunProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Style Table Properties.
  /// </summary>
  [DataMember]
  public DMW.StyleTableProperties? StyleTableProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Style Table Row Properties.
  /// </summary>
  [DataMember]
  public DMW.TableStyleConditionalFormattingTableRowProperties? TableStyleConditionalFormattingTableRowProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Style Table Cell Properties.
  /// </summary>
  [DataMember]
  public DMW.StyleTableCellProperties? StyleTableCellProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
