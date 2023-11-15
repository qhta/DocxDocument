namespace DocumentModel.Drawings;


/// <summary>
///   Space Before.
/// </summary>
public partial class SpaceBefore: ModelElement<DXD.SpaceBefore>
{
  public SpaceBefore(): base(){ }
  
  public SpaceBefore(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SpaceBefore(DXD.SpaceBefore openXmlElement): base(openXmlElement) { }
  
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
