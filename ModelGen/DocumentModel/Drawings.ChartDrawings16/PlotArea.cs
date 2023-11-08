namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the PlotArea Class.
/// </summary>
public partial class PlotArea: ModelElement<DXO16DCD.PlotArea>
{
  public PlotArea(): base(){ }
  
  public PlotArea(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PlotArea(DXO16DCD.PlotArea openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   PlotAreaRegion.
  /// </summary>
  [DataMember]
  public DMDCD16.PlotAreaRegion? PlotAreaRegion
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.PlotAreaRegion>();
      if (element != null)
        return PlotAreaRegionConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.PlotAreaRegion>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PlotAreaRegionConverter.CreateOpenXmlElement<DXO16DCD.PlotAreaRegion>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDCD16.ShapeProperties? ShapeProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.ShapeProperties>();
      if (element != null)
        return ShapePropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.ShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapePropertiesConverter.CreateOpenXmlElement<DXO16DCD.ShapeProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDCD16.ExtensionList? ExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.ExtensionList>();
      if (element != null)
        return ExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DXO16DCD.ExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
