namespace DocumentModel.Drawings;


/// <summary>
///   This element is nearly identical to the representation of 2-D transforms for ordinary shapes (§20.1.7.6). The only addition is a member to represent the Child offset and the Child extents.
/// </summary>
public partial class TransformGroup: ModelElement<DXD.TransformGroup>
{
  public TransformGroup(): base(){ }
  
  public TransformGroup(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TransformGroup(DXD.TransformGroup openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Rotation. Specifies the clockwise rotation of a group in 1/64000 of a degree.
  /// </summary>
  [DataMember]
  public Int32? Rotation
  {
    get => _Element?.Rotation?.Value;
    set => _ExistingElement.Rotation = value;
  }
  
  
  /// <summary>
  ///   Horizontal flip. When true, this attribute defines that the group is flipped horizontally about the center of its bounding box.
  /// </summary>
  [DataMember]
  public Boolean? HorizontalFlip
  {
    get => _Element?.HorizontalFlip?.Value;
    set => _ExistingElement.HorizontalFlip = value;
  }
  
  
  /// <summary>
  ///   Vertical flip. When true, this attribute defines that the group is flipped vertically about the center of its bounding box.
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
  
  
  /// <summary>
  ///   Child Offset.
  /// </summary>
  [DataMember]
  public DMD.ChildOffset? ChildOffset
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Point2DType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Point2DType");
  }
  
  
  /// <summary>
  ///   Child Extents.
  /// </summary>
  [DataMember]
  public DMD.ChildExtents? ChildExtents
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.PositiveSize2DType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.PositiveSize2DType");
  }
  
}
