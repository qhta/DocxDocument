namespace DocumentModel.Drawings;


/// <summary>
///   Defines the TextSpacingType Class.
/// </summary>
public partial class TextSpacingType: ModelElement<DXD.TextSpacingType>
{
  public TextSpacingType(): base(){ }
  
  public TextSpacingType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextSpacingType(DXD.TextSpacingType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Spacing Percent.
  /// </summary>
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
  
  
  /// <summary>
  ///   Spacing Points.
  /// </summary>
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
