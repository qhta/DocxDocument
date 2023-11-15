namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the RadarChartExtension Class.
/// </summary>
public partial class RadarChartExtension: ModelElement<DXDC.RadarChartExtension>
{
  public RadarChartExtension(): base(){ }
  
  public RadarChartExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RadarChartExtension(DXDC.RadarChartExtension openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   URI
  /// </summary>
  [DataMember]
  public String? Uri
  {
    get => _Element?.Uri;
    set => _ExistingElement.Uri = value;
  }
  
  [DataMember]
  public DMDC13.FilteredRadarSeries? FilteredRadarSeries
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
