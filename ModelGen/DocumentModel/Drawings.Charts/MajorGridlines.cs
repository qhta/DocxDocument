namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Major Gridlines.
/// </summary>
public partial class MajorGridlines: ModelElement<DXDC.MajorGridlines>
{
  public MajorGridlines(): base(){ }
  
  public MajorGridlines(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MajorGridlines(DXDC.MajorGridlines openXmlElement): base(openXmlElement) { }
  
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
