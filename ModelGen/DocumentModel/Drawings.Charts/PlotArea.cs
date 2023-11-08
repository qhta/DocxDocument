namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Plot data and formatting.
/// </summary>
public partial class PlotArea: ModelElement<DXDC.PlotArea>
{
  public PlotArea(): base(){ }
  
  public PlotArea(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PlotArea(DXDC.PlotArea openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Layout.
  /// </summary>
  [DataMember]
  public DMDC.Layout? Layout
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.Layout>();
      if (element != null)
        return LayoutConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Layout>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LayoutConverter.CreateOpenXmlElement<DXDC.Layout>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.DataTable? DataTable
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.DataTable>();
      if (element != null)
        return DataTableConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.DataTable>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataTableConverter.CreateOpenXmlElement<DXDC.DataTable>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.ShapeProperties? ShapeProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.ShapeProperties>();
      if (element != null)
        return ShapePropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapePropertiesConverter.CreateOpenXmlElement<DXDC.ShapeProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.ExtensionList? ExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.ExtensionList>();
      if (element != null)
        return ExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DXDC.ExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
