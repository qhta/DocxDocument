namespace DocumentModel.Wordprocessing;


/// <summary>
///   Information About Single HTML div Element.
/// </summary>
public partial class Div: ModelElement<DXW.Div>
{
  public Div(): base(){ }
  
  public Div(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Div(DXW.Div openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   div Data ID
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? Id
  {
    get => HexIntConverter.GetValue(_Element?.Id);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Data for HTML blockquote Element.
  /// </summary>
  [DataMember]
  public DMW.BlockQuote? BlockQuote
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
  
  /// <summary>
  ///   Data for HTML body Element.
  /// </summary>
  [DataMember]
  public DMW.BodyDiv? BodyDiv
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.OnOffType");
  }
  
  
  /// <summary>
  ///   Left Margin for HTML div.
  /// </summary>
  [DataMember]
  public DMW.LeftMarginDiv? LeftMarginDiv
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.SignedTwipsMeasureType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.SignedTwipsMeasureType");
  }
  
  
  /// <summary>
  ///   Right Margin for HTML div.
  /// </summary>
  [DataMember]
  public DMW.RightMarginDiv? RightMarginDiv
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.SignedTwipsMeasureType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.SignedTwipsMeasureType");
  }
  
  
  /// <summary>
  ///   Top Margin for HTML div.
  /// </summary>
  [DataMember]
  public DMW.TopMarginDiv? TopMarginDiv
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.SignedTwipsMeasureType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.SignedTwipsMeasureType");
  }
  
  
  /// <summary>
  ///   Bottom Margin for HTML div.
  /// </summary>
  [DataMember]
  public DMW.BottomMarginDiv? BottomMarginDiv
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.SignedTwipsMeasureType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.SignedTwipsMeasureType");
  }
  
  
  /// <summary>
  ///   Set of Borders for HTML div.
  /// </summary>
  [DataMember]
  public DMW.DivBorder? DivBorder
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
