namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the GeoPolygon Class.
/// </summary>
public partial class GeoPolygon: ModelElement<DXO16DCD.GeoPolygon>
{
  public GeoPolygon(): base(){ }
  
  public GeoPolygon(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GeoPolygon(DXO16DCD.GeoPolygon openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   polygonId, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? PolygonId
  {
    get => HexIntConverter.GetValue(_Element?.PolygonId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   numPoints, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Int64? NumPoints
  {
    get => _Element?.NumPoints?.Value;
    set => _ExistingElement.NumPoints = value;
  }
  
  
  /// <summary>
  ///   pcaRings, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? PcaRings
  {
    get => _Element?.PcaRings;
    set => _ExistingElement.PcaRings = value;
  }
  
}
