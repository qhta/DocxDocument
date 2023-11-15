namespace DocumentModel.Drawings.ChartDrawings10;


/// <summary>
///   Defines the Transform2D Class.
/// </summary>
public partial class Transform2D: ModelElement<DXO10DCD.Transform2D>
{
  public Transform2D(): base(){ }
  
  public Transform2D(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Transform2D(DXO10DCD.Transform2D openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Rotation
  /// </summary>
  [DataMember]
  public Int32? Rotation
  {
    get => _Element?.Rotation?.Value;
    set => _ExistingElement.Rotation = value;
  }
  
  
  /// <summary>
  ///   Horizontal Flip
  /// </summary>
  [DataMember]
  public Boolean? HorizontalFlip
  {
    get => _Element?.HorizontalFlip?.Value;
    set => _ExistingElement.HorizontalFlip = value;
  }
  
  
  /// <summary>
  ///   Vertical Flip
  /// </summary>
  [DataMember]
  public Boolean? VerticalFlip
  {
    get => _Element?.VerticalFlip?.Value;
    set => _ExistingElement.VerticalFlip = value;
  }
  
  
  /// <summary>
  ///   Offset.
  /// </summary>
  [DataMember]
  public DMD.Offset? Offset
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Point2DType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Point2DType");
  }
  
  
  /// <summary>
  ///   Extents.
  /// </summary>
  [DataMember]
  public DMD.Extents? Extents
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.PositiveSize2DType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.PositiveSize2DType");
  }
  
}
