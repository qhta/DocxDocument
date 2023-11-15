namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Text Body.
/// </summary>
public partial class TextBody: ModelElement<DXDDD.TextBody>
{
  public TextBody(): base(){ }
  
  public TextBody(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextBody(DXDDD.TextBody openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Body Properties.
  /// </summary>
  [DataMember]
  public DMD.BodyProperties? BodyProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Text List Styles.
  /// </summary>
  [DataMember]
  public DMD.ListStyle? ListStyle
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
