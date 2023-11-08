namespace DocumentModel.Drawings;


/// <summary>
///   Defines the PositiveSize2DType Class.
/// </summary>
public partial class PositiveSize2DType: ModelElement<DXD.PositiveSize2DType>
{
  public PositiveSize2DType(): base(){ }
  
  public PositiveSize2DType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PositiveSize2DType(DXD.PositiveSize2DType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Extent Length
  /// </summary>
  [DataMember]
  public Int64? Cx
  {
    get
    {
      return _Element?.Cx?.Value;
    }
    set
    {
      _ExistingElement.Cx = value;
    }
  }
  
  
  /// <summary>
  ///   Extent Width
  /// </summary>
  [DataMember]
  public Int64? Cy
  {
    get
    {
      return _Element?.Cy?.Value;
    }
    set
    {
      _ExistingElement.Cy = value;
    }
  }
  
}
