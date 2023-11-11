namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the existence of a custom geometric shape. This shape consists of a series of lines and curves described within a creation path. In addition to this there can also be adjust values, guides, adjust handles, connection sites and an inscribed rectangle specified for this custom geometric shape.
/// </summary>
public partial class CustomGeometry: ModelElement<DXD.CustomGeometry>
{
  public CustomGeometry(): base(){ }
  
  public CustomGeometry(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CustomGeometry(DXD.CustomGeometry openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Adjust Value List.
  /// </summary>
  [DataMember]
  public DMD.AdjustValueList? AdjustValueList
  {
    get
    {
      return _Element?.GetObject<DMD.AdjustValueList,DXD.AdjustValueList>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.AdjustValueList,DXD.AdjustValueList>(value);
    }
  }
  
  
  /// <summary>
  ///   List of Shape Guides.
  /// </summary>
  [DataMember]
  public DMD.ShapeGuideList? ShapeGuideList
  {
    get
    {
      return _Element?.GetObject<DMD.ShapeGuideList,DXD.ShapeGuideList>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.ShapeGuideList,DXD.ShapeGuideList>(value);
    }
  }
  
  
  /// <summary>
  ///   List of Shape Adjust Handles.
  /// </summary>
  [DataMember]
  public DMD.AdjustHandleList? AdjustHandleList
  {
    get
    {
      return _Element?.GetObject<DMD.AdjustHandleList,DXD.AdjustHandleList>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.AdjustHandleList,DXD.AdjustHandleList>(value);
    }
  }
  
  
  /// <summary>
  ///   List of Shape Connection Sites.
  /// </summary>
  [DataMember]
  public DMD.ConnectionSiteList? ConnectionSiteList
  {
    get
    {
      return _Element?.GetObject<DMD.ConnectionSiteList,DXD.ConnectionSiteList>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.ConnectionSiteList,DXD.ConnectionSiteList>(value);
    }
  }
  
  
  /// <summary>
  ///   Shape Text Rectangle.
  /// </summary>
  [DataMember]
  public DMD.Rectangle? Rectangle
  {
    get
    {
      return _Element?.GetObject<DMD.Rectangle,DXD.Rectangle>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.Rectangle,DXD.Rectangle>(value);
    }
  }
  
  
  /// <summary>
  ///   List of Shape Paths.
  /// </summary>
  [DataMember]
  public DMD.PathList? PathList
  {
    get
    {
      return _Element?.GetObject<DMD.PathList,DXD.PathList>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.PathList,DXD.PathList>(value);
    }
  }
  
}
