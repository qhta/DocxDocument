namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the PlotAreaRegion Class.
/// </summary>
public partial class PlotAreaRegion: ModelElement<DXO16DCD.PlotAreaRegion>
{
  public PlotAreaRegion(): base(){ }
  
  public PlotAreaRegion(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PlotAreaRegion(DXO16DCD.PlotAreaRegion openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   PlotSurface.
  /// </summary>
  [DataMember]
  public DMDCD16.PlotSurface? PlotSurface
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
