namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Data Model.
/// </summary>
public partial class DataModel: ModelElement<DXDDD.DataModel>
{
  public DataModel(): base(){ }
  
  public DataModel(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DataModel(DXDDD.DataModel openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Point List.
  /// </summary>
  [DataMember]
  public DMDD.PointList? PointList
  {
    get
    {
      return _Element?.GetObject<DMDD.PointList,DXDDD.PointList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDD.PointList,DXDDD.PointList>(value);
    }
  }
  
  
  /// <summary>
  ///   Connection List.
  /// </summary>
  [DataMember]
  public DMDD.ConnectionList? ConnectionList
  {
    get
    {
      return _Element?.GetObject<DMDD.ConnectionList,DXDDD.ConnectionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDD.ConnectionList,DXDDD.ConnectionList>(value);
    }
  }
  
  
  /// <summary>
  ///   Background Formatting.
  /// </summary>
  [DataMember]
  public DMDD.Background? Background
  {
    get
    {
      return _Element?.GetObject<DMDD.Background,DXDDD.Background>();
    }
    set
    {
      _ExistingElement.SetObject<DMDD.Background,DXDDD.Background>(value);
    }
  }
  
  
  /// <summary>
  ///   Whole E2O Formatting.
  /// </summary>
  [DataMember]
  public DMDD.Whole? Whole
  {
    get
    {
      return _Element?.GetObject<DMDD.Whole,DXDDD.Whole>();
    }
    set
    {
      _ExistingElement.SetObject<DMDD.Whole,DXDDD.Whole>(value);
    }
  }
  
  
  /// <summary>
  ///   DataModelExtensionList.
  /// </summary>
  [DataMember]
  public DMDD.DataModelExtensionList? DataModelExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDD.DataModelExtensionList,DXDDD.DataModelExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDD.DataModelExtensionList,DXDDD.DataModelExtensionList>(value);
    }
  }
  
}
