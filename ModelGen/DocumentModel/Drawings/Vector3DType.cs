namespace DocumentModel.Drawings;


/// <summary>
///   Defines the Vector3DType Class.
/// </summary>
public partial class Vector3DType: ModelElement<DXD.Vector3DType>
{
  public Vector3DType(): base(){ }
  
  public Vector3DType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Vector3DType(DXD.Vector3DType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Distance along X-axis in 3D
  /// </summary>
  [DataMember]
  public Int64? Dx
  {
    get
    {
      return _Element?.Dx?.Value;
    }
    set
    {
      _ExistingElement.Dx = value;
    }
  }
  
  
  /// <summary>
  ///   Distance along Y-axis in 3D
  /// </summary>
  [DataMember]
  public Int64? Dy
  {
    get
    {
      return _Element?.Dy?.Value;
    }
    set
    {
      _ExistingElement.Dy = value;
    }
  }
  
  
  /// <summary>
  ///   Distance along Z-axis in 3D
  /// </summary>
  [DataMember]
  public Int64? Dz
  {
    get
    {
      return _Element?.Dz?.Value;
    }
    set
    {
      _ExistingElement.Dz = value;
    }
  }
  
}
