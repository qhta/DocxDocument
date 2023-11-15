namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the MinorGridlinesGridlines Class.
/// </summary>
public partial class MinorGridlinesGridlines: ModelElement<DXO16DCD.MinorGridlinesGridlines>
{
  public MinorGridlinesGridlines(): base(){ }
  
  public MinorGridlinesGridlines(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MinorGridlinesGridlines(DXO16DCD.MinorGridlinesGridlines openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMDCD16.ShapeProperties? ShapeProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  [DataMember]
  public DMDCD16.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
