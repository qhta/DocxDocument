namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Data Model.
/// </summary>
public partial class DataModelRoot: ModelElement<DXDDD.DataModelRoot>
{
  public DataModelRoot(): base(){ }
  
  public DataModelRoot(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DataModelRoot(DXDDD.DataModelRoot openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Point List.
  /// </summary>
  [DataMember]
  public DMDD.PointList? PointList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDDD.PointList>();
      if (element != null)
        return PointListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDDD.PointList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PointListConverter.CreateOpenXmlElement<DXDDD.PointList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDDD.ConnectionList>();
      if (element != null)
        return ConnectionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDDD.ConnectionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ConnectionListConverter.CreateOpenXmlElement<DXDDD.ConnectionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDDD.Background>();
      if (element != null)
        return BackgroundConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDDD.Background>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BackgroundConverter.CreateOpenXmlElement<DXDDD.Background>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDDD.Whole>();
      if (element != null)
        return WholeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDDD.Whole>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = WholeConverter.CreateOpenXmlElement<DXDDD.Whole>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDDD.DataModelExtensionList>();
      if (element != null)
        return DataModelExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDDD.DataModelExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataModelExtensionListConverter.CreateOpenXmlElement<DXDDD.DataModelExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
