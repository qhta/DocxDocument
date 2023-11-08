namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the HighLowLines Class.
/// </summary>
public partial class HighLowLines: ModelElement<DXDC.HighLowLines>
{
  public HighLowLines(): base(){ }
  
  public HighLowLines(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HighLowLines(DXDC.HighLowLines openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMDC.ChartShapeProperties? ChartShapeProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.ChartShapeProperties>();
      if (element != null)
        return ChartShapePropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ChartShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ChartShapePropertiesConverter.CreateOpenXmlElement<DXDC.ChartShapeProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
