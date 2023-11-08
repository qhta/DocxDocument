namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a soft edge effect. The edges of the shape are blurred, while the fill is not affected.
/// </summary>
public partial class SoftEdge: ModelElement<DXD.SoftEdge>
{
  public SoftEdge(): base(){ }
  
  public SoftEdge(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SoftEdge(DXD.SoftEdge openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies the radius of blur to apply to the edges.
  /// </summary>
  [DataMember]
  public Int64? Radius
  {
    get
    {
      return _Element?.Radius?.Value;
    }
    set
    {
      _ExistingElement.Radius = value;
    }
  }
  
}
