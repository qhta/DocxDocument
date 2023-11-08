namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a dash stop primitive. Dashing schemes are built by specifying an ordered list of dash stop primitive. A dash stop primitive consists of a dash and a space.
/// </summary>
public partial class DashStop: ModelElement<DXD.DashStop>
{
  public DashStop(): base(){ }
  
  public DashStop(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DashStop(DXD.DashStop openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies the length of the dash relative to the line width.
  /// </summary>
  [DataMember]
  public Int32? DashLength
  {
    get
    {
      return _Element?.DashLength?.Value;
    }
    set
    {
      _ExistingElement.DashLength = value;
    }
  }
  
  
  /// <summary>
  ///   Specifies the length of the space relative to the line width.
  /// </summary>
  [DataMember]
  public Int32? SpaceLength
  {
    get
    {
      return _Element?.SpaceLength?.Value;
    }
    set
    {
      _ExistingElement.SpaceLength = value;
    }
  }
  
}
