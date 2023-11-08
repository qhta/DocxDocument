namespace DocumentModel.Drawings;


/// <summary>
///   Line Spacing.
/// </summary>
public partial class LineSpacing: ModelElement<DXD.LineSpacing>
{
  public LineSpacing(): base(){ }
  
  public LineSpacing(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LineSpacing(DXD.LineSpacing openXmlElement): base(openXmlElement) { }
  
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
