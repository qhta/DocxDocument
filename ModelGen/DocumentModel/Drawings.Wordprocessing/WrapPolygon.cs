namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Tight Wrapping Extents Polygon.
/// </summary>
public partial class WrapPolygon: ModelElement<DXDW.WrapPolygon>
{
  public WrapPolygon(): base(){ }
  
  public WrapPolygon(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public WrapPolygon(DXDW.WrapPolygon openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Wrapping Points Modified
  /// </summary>
  [DataMember]
  public Boolean? Edited
  {
    get => _Element?.Edited?.Value;
    set => _ExistingElement.Edited = value;
  }
  
  
  /// <summary>
  ///   Wrapping Polygon Start.
  /// </summary>
  [DataMember]
  public DMDW.StartPoint? StartPoint
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Wordprocessing.Point2DType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Wordprocessing.Point2DType");
  }
  
}
