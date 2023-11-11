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
      return _Element?.GetObject<DMDC10.DropZoneFilter,DXO10DC.DropZoneFilter>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC10.DropZoneFilter,DXO10DC.DropZoneFilter>(value);
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
      return _Element?.GetObject<DMDC10.DropZoneCategories,DXO10DC.DropZoneCategories>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC10.DropZoneCategories,DXO10DC.DropZoneCategories>(value);
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
      return _Element?.GetObject<DMDC10.DropZoneData,DXO10DC.DropZoneData>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC10.DropZoneData,DXO10DC.DropZoneData>(value);
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
      return _Element?.GetObject<DMDC10.DropZoneSeries,DXO10DC.DropZoneSeries>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC10.DropZoneSeries,DXO10DC.DropZoneSeries>(value);
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
      return _Element?.GetObject<DMDC10.DropZonesVisible,DXO10DC.DropZonesVisible>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC10.DropZonesVisible,DXO10DC.DropZonesVisible>(value);
    }
  }
  
}
