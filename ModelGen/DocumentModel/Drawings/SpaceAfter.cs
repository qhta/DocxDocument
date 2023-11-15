namespace DocumentModel.Drawings;


/// <summary>
///   Space After.
/// </summary>
public partial class SpaceAfter: ModelElement<DXD.SpaceAfter>
{
  public SpaceAfter(): base(){ }
  
  public SpaceAfter(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SpaceAfter(DXD.SpaceAfter openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public Int32? SpacingPercent
  {
    get => _Element?.GetIntVal<Int32, DXD.SpacingPercent>();
    set => _ExistingElement.SetIntVal<Int32, DXD.SpacingPercent>(value);
  }
  
  [DataMember]
  public Int32? SpacingPoints
  {
    get => _Element?.GetIntVal<Int32, DXD.SpacingPoints>();
    set => _ExistingElement.SetIntVal<Int32, DXD.SpacingPoints>(value);
  }
  
}
