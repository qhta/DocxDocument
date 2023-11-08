namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Down Bars.
/// </summary>
public partial class DownBars: ModelElement<DXDC.DownBars>
{
  public DownBars(): base(){ }
  
  public DownBars(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DownBars(DXDC.DownBars openXmlElement): base(openXmlElement) { }
  
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
