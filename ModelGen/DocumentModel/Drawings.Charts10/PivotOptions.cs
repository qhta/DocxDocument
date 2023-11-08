namespace DocumentModel.Drawings.Charts10;


/// <summary>
///   Defines the PivotOptions Class.
/// </summary>
public partial class PivotOptions: ModelElement<DXO10DC.PivotOptions>
{
  public PivotOptions(): base(){ }
  
  public PivotOptions(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PivotOptions(DXO10DC.PivotOptions openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   DropZoneFilter.
  /// </summary>
  [DataMember]
  public DMDC10.DropZoneFilter? DropZoneFilter
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10DC.DropZoneFilter>();
      if (element != null)
        return DropZoneFilterConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10DC.DropZoneFilter>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DropZoneFilterConverter.CreateOpenXmlElement<DXO10DC.DropZoneFilter>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   DropZoneCategories.
  /// </summary>
  [DataMember]
  public DMDC10.DropZoneCategories? DropZoneCategories
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10DC.DropZoneCategories>();
      if (element != null)
        return DropZoneCategoriesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10DC.DropZoneCategories>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DropZoneCategoriesConverter.CreateOpenXmlElement<DXO10DC.DropZoneCategories>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   DropZoneData.
  /// </summary>
  [DataMember]
  public DMDC10.DropZoneData? DropZoneData
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10DC.DropZoneData>();
      if (element != null)
        return DropZoneDataConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10DC.DropZoneData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DropZoneDataConverter.CreateOpenXmlElement<DXO10DC.DropZoneData>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   DropZoneSeries.
  /// </summary>
  [DataMember]
  public DMDC10.DropZoneSeries? DropZoneSeries
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10DC.DropZoneSeries>();
      if (element != null)
        return DropZoneSeriesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10DC.DropZoneSeries>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DropZoneSeriesConverter.CreateOpenXmlElement<DXO10DC.DropZoneSeries>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   DropZonesVisible.
  /// </summary>
  [DataMember]
  public DMDC10.DropZonesVisible? DropZonesVisible
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10DC.DropZonesVisible>();
      if (element != null)
        return DropZonesVisibleConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10DC.DropZonesVisible>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DropZonesVisibleConverter.CreateOpenXmlElement<DXO10DC.DropZonesVisible>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
