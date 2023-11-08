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
      var element = _Element?.GetFirstChild<DXO16DCD.ExtremeValueColorPosition>();
      if (element != null)
        return ExtremeValueColorPositionConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.ExtremeValueColorPosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtremeValueColorPositionConverter.CreateOpenXmlElement<DXO16DCD.ExtremeValueColorPosition>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      SimpleValueConverter.SetValue<DXO16DCD.NumberColorPosition,System.Double>(openXmlElement, value);
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
      SimpleValueConverter.SetValue<DXO16DCD.PercentageColorPosition,System.Double>(openXmlElement, value);
    }
  }
  
}
