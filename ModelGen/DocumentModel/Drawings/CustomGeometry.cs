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
      var element = _Element?.GetFirstChild<DXD.AdjustValueList>();
      if (element != null)
        return AdjustValueListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.AdjustValueList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AdjustValueListConverter.CreateOpenXmlElement<DXD.AdjustValueList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.ShapeGuideList>();
      if (element != null)
        return ShapeGuideListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.ShapeGuideList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapeGuideListConverter.CreateOpenXmlElement<DXD.ShapeGuideList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.AdjustHandleList>();
      if (element != null)
        return AdjustHandleListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.AdjustHandleList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AdjustHandleListConverter.CreateOpenXmlElement<DXD.AdjustHandleList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.ConnectionSiteList>();
      if (element != null)
        return ConnectionSiteListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.ConnectionSiteList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ConnectionSiteListConverter.CreateOpenXmlElement<DXD.ConnectionSiteList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.Rectangle>();
      if (element != null)
        return RectangleConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.Rectangle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RectangleConverter.CreateOpenXmlElement<DXD.Rectangle>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXD.PathList>();
      if (element != null)
        return PathListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.PathList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PathListConverter.CreateOpenXmlElement<DXD.PathList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
