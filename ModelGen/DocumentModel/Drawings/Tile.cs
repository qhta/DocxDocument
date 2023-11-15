namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies that a BLIP should be tiled to fill the available space. This element defines a &quot;tile&quot; rectangle within the bounding box. The image is encompassed within the tile rectangle, and the tile rectangle is tiled across the bounding box to fill the entire area.
/// </summary>
public partial class Tile: ModelElement<DXD.Tile>
{
  public Tile(): base(){ }
  
  public Tile(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Tile(DXD.Tile openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies additional horizontal offset after alignment.
  /// </summary>
  [DataMember]
  public Int64? HorizontalOffset
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
  }
  
  
  /// <summary>
  ///   Specifies additional vertical offset after alignment.
  /// </summary>
  [DataMember]
  public Int64? VerticalOffset
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
  }
  
  
  /// <summary>
  ///   Specifies the amount to horizontally scale the srcRect.
  /// </summary>
  [DataMember]
  public Int32? HorizontalRatio
  {
    get => _Element?.HorizontalRatio?.Value;
    set => _ExistingElement.HorizontalRatio = value;
  }
  
  
  /// <summary>
  ///   Specifies the amount to vertically scale the srcRect.
  /// </summary>
  [DataMember]
  public Int32? VerticalRatio
  {
    get => _Element?.VerticalRatio?.Value;
    set => _ExistingElement.VerticalRatio = value;
  }
  
}
