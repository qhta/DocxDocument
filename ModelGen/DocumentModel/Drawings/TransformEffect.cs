namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a transform effect. The transform is applied to each point in the shape's geometry using the following matrix:
/// </summary>
public partial class TransformEffect: ModelElement<DXD.TransformEffect>
{
  public TransformEffect(): base(){ }
  
  public TransformEffect(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TransformEffect(DXD.TransformEffect openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies a percentage by which to horizontally scale the object.
  /// </summary>
  [DataMember]
  public Int32? HorizontalRatio
  {
    get
    {
      return _Element?.HorizontalRatio?.Value;
    }
    set
    {
      _ExistingElement.HorizontalRatio = value;
    }
  }
  
  
  /// <summary>
  ///   Specifies a percentage by which to vertically scale the object.
  /// </summary>
  [DataMember]
  public Int32? VerticalRatio
  {
    get
    {
      return _Element?.VerticalRatio?.Value;
    }
    set
    {
      _ExistingElement.VerticalRatio = value;
    }
  }
  
  
  /// <summary>
  ///   Specifies the horizontal skew angle, defined as the angle between the top-left corner and bottom-left corner of the object's original bounding box. If positive, the bottom edge of the shape is positioned to the right relative to the top edge.
  /// </summary>
  [DataMember]
  public Int32? HorizontalSkew
  {
    get
    {
      return _Element?.HorizontalSkew?.Value;
    }
    set
    {
      _ExistingElement.HorizontalSkew = value;
    }
  }
  
  
  /// <summary>
  ///   Specifies the vertical skew angle, defined as the angle between the top-left corner and top-right corner of the object's original bounding box. If positive, the right edge of the object is positioned lower relative to the left edge.
  /// </summary>
  [DataMember]
  public Int32? VerticalSkew
  {
    get
    {
      return _Element?.VerticalSkew?.Value;
    }
    set
    {
      _ExistingElement.VerticalSkew = value;
    }
  }
  
  
  /// <summary>
  ///   Specifies an amount by which to shift the object along the x-axis.
  /// </summary>
  [DataMember]
  public Int64? HorizontalShift
  {
    get
    {
      return _Element?.HorizontalShift?.Value;
    }
    set
    {
      _ExistingElement.HorizontalShift = value;
    }
  }
  
  
  /// <summary>
  ///   Specifies an amount by which to shift the object along the y-axis.
  /// </summary>
  [DataMember]
  public Int64? VerticalShift
  {
    get
    {
      return _Element?.VerticalShift?.Value;
    }
    set
    {
      _ExistingElement.VerticalShift = value;
    }
  }
  
}
