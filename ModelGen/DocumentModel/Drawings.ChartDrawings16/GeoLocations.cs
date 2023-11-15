namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the GeoLocations Class.
/// </summary>
public partial class GeoLocations: ModelElement<DXO16DCD.GeoLocations>
{
  public GeoLocations(): base(){ }
  
  public GeoLocations(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GeoLocations(DXO16DCD.GeoLocations openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   GeoLocation.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoLocation? GeoLocation
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
