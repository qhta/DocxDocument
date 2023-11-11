namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Point.
/// </summary>
public partial class Point: ModelElement<DXDDD.Point>
{
  public Point(): base(){ }
  
  public Point(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Point(DXDDD.Point openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Model Identifier
  /// </summary>
  [DataMember]
  public String? ModelId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.ModelId);
    }
    set
    {
      _ExistingElement.ModelId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Connection Identifier
  /// </summary>
  [DataMember]
  public String? ConnectionId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.ConnectionId);
    }
    set
    {
      _ExistingElement.ConnectionId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Property Set.
  /// </summary>
  [DataMember]
  public DMDD.PropertySet? PropertySet
  {
    get
    {
      return _Element?.GetObject<DMDD.PropertySet,DXDDD.PropertySet>();
    }
    set
    {
      _ExistingElement.SetObject<DMDD.PropertySet,DXDDD.PropertySet>(value);
    }
  }
  
  
  /// <summary>
  ///   Shape Properties.
  /// </summary>
  [DataMember]
  public DMDD.ShapeProperties? ShapeProperties
  {
    get
    {
      return _Element?.GetObject<DMDD.ShapeProperties,DXDDD.ShapeProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDD.ShapeProperties,DXDDD.ShapeProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   Text Body.
  /// </summary>
  [DataMember]
  public DMDD.TextBody? TextBody
  {
    get
    {
      return _Element?.GetObject<DMDD.TextBody,DXDDD.TextBody>();
    }
    set
    {
      _ExistingElement.SetObject<DMDD.TextBody,DXDDD.TextBody>(value);
    }
  }
  
  
  /// <summary>
  ///   PtExtensionList.
  /// </summary>
  [DataMember]
  public DMDD.PtExtensionList? PtExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDD.PtExtensionList,DXDDD.PtExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDD.PtExtensionList,DXDDD.PtExtensionList>(value);
    }
  }
  
}
