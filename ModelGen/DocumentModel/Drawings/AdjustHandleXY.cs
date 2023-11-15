namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies an XY-based adjust handle for a custom shape. The position of this adjust handle is specified by the corresponding pos child element. The allowed adjustment of this adjust handle are specified via it's min and max type attributes. Based on the adjustment of this adjust handle certain corresponding guides are updated to contain these values.
/// </summary>
public partial class AdjustHandleXY: ModelElement<DXD.AdjustHandleXY>
{
  public AdjustHandleXY(): base(){ }
  
  public AdjustHandleXY(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AdjustHandleXY(DXD.AdjustHandleXY openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies the name of the guide that is updated with the adjustment x position from this adjust handle.
  /// </summary>
  [DataMember]
  public String? XAdjustmentGuide
  {
    get => _Element?.XAdjustmentGuide;
    set => _ExistingElement.XAdjustmentGuide = value;
  }
  
  
  /// <summary>
  ///   Specifies the minimum horizontal position that is allowed for this adjustment handle. If this attribute is omitted, then it is assumed that this adjust handle cannot move in the x direction. That is the maxX and minX are equal.
  /// </summary>
  [DataMember]
  public String? MinX
  {
    get => _Element?.MinX;
    set => _ExistingElement.MinX = value;
  }
  
  
  /// <summary>
  ///   Specifies the maximum horizontal position that is allowed for this adjustment handle. If this attribute is omitted, then it is assumed that this adjust handle cannot move in the x direction. That is the maxX and minX are equal.
  /// </summary>
  [DataMember]
  public String? MaxX
  {
    get => _Element?.MaxX;
    set => _ExistingElement.MaxX = value;
  }
  
  
  /// <summary>
  ///   Specifies the name of the guide that is updated with the adjustment y position from this adjust handle.
  /// </summary>
  [DataMember]
  public String? YAdjustmentGuide
  {
    get => _Element?.YAdjustmentGuide;
    set => _ExistingElement.YAdjustmentGuide = value;
  }
  
  
  /// <summary>
  ///   Specifies the minimum vertical position that is allowed for this adjustment handle. If this attribute is omitted, then it is assumed that this adjust handle cannot move in the y direction. That is the maxY and minY are equal.
  /// </summary>
  [DataMember]
  public String? MinY
  {
    get => _Element?.MinY;
    set => _ExistingElement.MinY = value;
  }
  
  
  /// <summary>
  ///   Specifies the maximum vertical position that is allowed for this adjustment handle. If this attribute is omitted, then it is assumed that this adjust handle cannot move in the y direction. That is the maxY and minY are equal.
  /// </summary>
  [DataMember]
  public String? MaxY
  {
    get => _Element?.MaxY;
    set => _ExistingElement.MaxY = value;
  }
  
  
  /// <summary>
  ///   Position.
  /// </summary>
  [DataMember]
  public DMD.Position? Position
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.AdjustPoint2DType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.AdjustPoint2DType");
  }
  
}
