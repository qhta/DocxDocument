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
    get => _Element?.GetIntVal<Double, DXO16DCD.NumberColorPosition>();
    set => _ExistingElement.SetIntVal<Double, DXO16DCD.NumberColorPosition>(value);
  }
  
  
  /// <summary>
  ///   PercentageColorPosition.
  /// </summary>
  [DataMember]
  public Double? PercentageColorPosition
  {
    get => _Element?.GetIntVal<Double, DXO16DCD.PercentageColorPosition>();
    set => _ExistingElement.SetIntVal<Double, DXO16DCD.PercentageColorPosition>(value);
  }
  
}
