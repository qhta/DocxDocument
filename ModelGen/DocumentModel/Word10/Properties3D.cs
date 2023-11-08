namespace DocumentModel.Word10;


/// <summary>
///   This element specifies the 3-D properties of text, including bevel, extrusion, contour, and material. By default, text does not have 3-D properties.
/// </summary>
public partial class Properties3D: ModelElement<DXO10W.Properties3D>
{
  public Properties3D(): base(){ }
  
  public Properties3D(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Properties3D(DXO10W.Properties3D openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   extrusionH, this property is only available in Office 2010 and later.
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
  ///   contourW, this property is only available in Office 2010 and later.
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
  ///   BevelTop.
  /// </summary>
  [DataMember]
  public DMW10.BevelTop? BevelTop
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10W.BevelTop>();
      if (element != null)
        return BevelTopConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10W.BevelTop>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BevelTopConverter.CreateOpenXmlElement<DXO10W.BevelTop>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   BevelBottom.
  /// </summary>
  [DataMember]
  public DMW10.BevelBottom? BevelBottom
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10W.BevelBottom>();
      if (element != null)
        return BevelBottomConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10W.BevelBottom>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BevelBottomConverter.CreateOpenXmlElement<DXO10W.BevelBottom>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ExtrusionColor.
  /// </summary>
  [DataMember]
  public DMW10.ExtrusionColor? ExtrusionColor
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10W.ExtrusionColor>();
      if (element != null)
        return ExtrusionColorConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10W.ExtrusionColor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtrusionColorConverter.CreateOpenXmlElement<DXO10W.ExtrusionColor>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ContourColor.
  /// </summary>
  [DataMember]
  public DMW10.ContourColor? ContourColor
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10W.ContourColor>();
      if (element != null)
        return ContourColorConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10W.ContourColor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ContourColorConverter.CreateOpenXmlElement<DXO10W.ContourColor>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
