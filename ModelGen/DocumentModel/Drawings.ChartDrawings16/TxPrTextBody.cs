namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the TxPrTextBody Class.
/// </summary>
public partial class TxPrTextBody: ModelElement<DXO16DCD.TxPrTextBody>
{
  public TxPrTextBody(): base(){ }
  
  public TxPrTextBody(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TxPrTextBody(DXO16DCD.TxPrTextBody openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMD.BodyProperties? BodyProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  [DataMember]
  public DMD.ListStyle? ListStyle
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
