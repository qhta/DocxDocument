namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the MaxValueColorEndPosition Class.
/// </summary>
public partial class MaxValueColorEndPosition: ModelElement<DXO16DCD.MaxValueColorEndPosition>
{
  public MaxValueColorEndPosition(): base(){ }
  
  public MaxValueColorEndPosition(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MaxValueColorEndPosition(DXO16DCD.MaxValueColorEndPosition openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMDCD16.ExtremeValueColorPosition? ExtremeValueColorPosition
  {
    get
    {
      return _Element?.GetObject<DMDCD16.ExtremeValueColorPosition,DXO16DCD.ExtremeValueColorPosition>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.ExtremeValueColorPosition,DXO16DCD.ExtremeValueColorPosition>(value);
    }
  }
  
  [DataMember]
  public Double? NumberColorPosition
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXO16DCD.NumberColorPosition>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXO16DCD.NumberColorPosition,System.Double>(_ExistingElement, value);
    }
  }
  
  [DataMember]
  public Double? PercentageColorPosition
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXO16DCD.PercentageColorPosition>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXO16DCD.PercentageColorPosition,System.Double>(_ExistingElement, value);
    }
  }
  
}
