namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the MajorGridlinesGridlines Class.
/// </summary>
public partial class MajorGridlinesGridlines: ModelElement<DXO16DCD.MajorGridlinesGridlines>
{
  public MajorGridlinesGridlines(): base(){ }
  
  public MajorGridlinesGridlines(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MajorGridlinesGridlines(DXO16DCD.MajorGridlinesGridlines openXmlElement): base(openXmlElement) { }
  
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
