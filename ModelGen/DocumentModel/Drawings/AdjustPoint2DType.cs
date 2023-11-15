namespace DocumentModel.Drawings;


/// <summary>
///   Defines the AdjustPoint2DType Class.
/// </summary>
public partial class AdjustPoint2DType: ModelElement<DXD.AdjustPoint2DType>
{
  public AdjustPoint2DType(): base(){ }
  
  public AdjustPoint2DType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AdjustPoint2DType(DXD.AdjustPoint2DType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   X-Coordinate
  /// </summary>
  [DataMember]
  public String? X
  {
    get => _Element?.X;
    set => _ExistingElement.X = value;
  }
  
  
  /// <summary>
  ///   Y-Coordinate
  /// </summary>
  [DataMember]
  public String? Y
  {
    get => _Element?.Y;
    set => _ExistingElement.Y = value;
  }
  
}
