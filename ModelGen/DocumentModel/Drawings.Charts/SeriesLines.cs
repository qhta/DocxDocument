namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the SeriesLines Class.
/// </summary>
public partial class SeriesLines: ModelElement<DXDC.SeriesLines>
{
  public SeriesLines(): base(){ }
  
  public SeriesLines(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SeriesLines(DXDC.SeriesLines openXmlElement): base(openXmlElement) { }
  
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
