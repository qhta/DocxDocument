namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the TextBodyType Class.
/// </summary>
public partial class TextBodyType: ModelElement<DXDC.TextBodyType>
{
  public TextBodyType(): base(){ }
  
  public TextBodyType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextBodyType(DXDC.TextBodyType openXmlElement): base(openXmlElement) { }
  
  
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
