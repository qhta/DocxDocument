namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the HiddenShape3D Class.
/// </summary>
public partial class HiddenShape3D: ModelElement<DXO10D.HiddenShape3D>
{
  public HiddenShape3D(): base(){ }
  
  public HiddenShape3D(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HiddenShape3D(DXO10D.HiddenShape3D openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Shape Depth
  /// </summary>
  [DataMember]
  public Int64? Z
  {
    get
    {
      return _Element?.Z?.Value;
    }
    set
    {
      _ExistingElement.Z = value;
    }
  }
  
  
  /// <summary>
  ///   Extrusion Height
  /// </summary>
  [DataMember]
  public Int64? ExtrusionHeight
  {
    get
    {
      return _Element?.ExtrusionHeight?.Value;
    }
    set
    {
      _ExistingElement.ExtrusionHeight = value;
    }
  }
  
  
  /// <summary>
  ///   Contour Width
  /// </summary>
  [DataMember]
  public Int64? ContourWidth
  {
    get
    {
      return _Element?.ContourWidth?.Value;
    }
    set
    {
      _ExistingElement.ContourWidth = value;
    }
  }
  
  
  /// <summary>
  ///   Top Bevel.
  /// </summary>
  [DataMember]
  public DMD.BevelTop? BevelTop
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.BevelTop>();
      if (element != null)
        return BevelTopConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.BevelTop>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BevelTopConverter.CreateOpenXmlElement<DXD.BevelTop>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Bottom Bevel.
  /// </summary>
  [DataMember]
  public DMD.BevelBottom? BevelBottom
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.BevelBottom>();
      if (element != null)
        return BevelBottomConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.BevelBottom>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BevelBottomConverter.CreateOpenXmlElement<DXD.BevelBottom>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Extrusion Color.
  /// </summary>
  [DataMember]
  public DMD.ExtrusionColor? ExtrusionColor
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.ExtrusionColor>();
      if (element != null)
        return ExtrusionColorConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.ExtrusionColor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtrusionColorConverter.CreateOpenXmlElement<DXD.ExtrusionColor>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Contour Color.
  /// </summary>
  [DataMember]
  public DMD.ContourColor? ContourColor
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.ContourColor>();
      if (element != null)
        return ContourColorConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.ContourColor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ContourColorConverter.CreateOpenXmlElement<DXD.ContourColor>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [DataMember]
  public DMD.ExtensionList? ExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.ExtensionList>();
      if (element != null)
        return ExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DXD.ExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
