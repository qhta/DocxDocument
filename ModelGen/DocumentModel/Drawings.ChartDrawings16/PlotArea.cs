namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the PlotArea Class.
/// </summary>
public partial class PlotArea: ModelElement<DXO16DCD.PlotArea>
{
  public PlotArea(): base(){ }
  
  public PlotArea(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PlotArea(DXO16DCD.PlotArea openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   PlotAreaRegion.
  /// </summary>
  [DataMember]
  public DMDCD16.PlotAreaRegion? PlotAreaRegion
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
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
