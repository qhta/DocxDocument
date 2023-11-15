namespace DocumentModel.Word10;


/// <summary>
///   This element specifies a gradient fill. A gradient fill is a fill that is characterized by a smooth gradual transition from one color to the next.
/// </summary>
public partial class GradientFillProperties: ModelElement<DXO10W.GradientFillProperties>
{
  public GradientFillProperties(): base(){ }
  
  public GradientFillProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GradientFillProperties(DXO10W.GradientFillProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   GradientStopList.
  /// </summary>
  [DataMember]
  public DMW10.GradientStopList? GradientStopList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  [DataMember]
  public DMW10.LinearShadeProperties? LinearShadeProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  [DataMember]
  public DMW10.PathShadeProperties? PathShadeProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
