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
