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
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXD.SpacingPercent>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXD.SpacingPercent,System.Int32>(openXmlElement, value);
    }
  }
  
  [DataMember]
  public Int32? SpacingPoints
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXD.SpacingPoints>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXD.SpacingPoints,System.Int32>(openXmlElement, value);
    }
  }
  
}
