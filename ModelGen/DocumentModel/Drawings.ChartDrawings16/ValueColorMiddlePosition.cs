namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the ValueColorMiddlePosition Class.
/// </summary>
public partial class ValueColorMiddlePosition: ModelElement<DXO16DCD.ValueColorMiddlePosition>
{
  public ValueColorMiddlePosition(): base(){ }
  
  public ValueColorMiddlePosition(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ValueColorMiddlePosition(DXO16DCD.ValueColorMiddlePosition openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   NumberColorPosition.
  /// </summary>
  [DataMember]
  public Double? NumberColorPosition
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXO16DCD.NumberColorPosition>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXO16DCD.NumberColorPosition,System.Double>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   PercentageColorPosition.
  /// </summary>
  [DataMember]
  public Double? PercentageColorPosition
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXO16DCD.PercentageColorPosition>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXO16DCD.PercentageColorPosition,System.Double>(openXmlElement, value);
    }
  }
  
}
