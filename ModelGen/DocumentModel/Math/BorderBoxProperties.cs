namespace DocumentModel.Math;


/// <summary>
///   Border Box Properties.
/// </summary>
public partial class BorderBoxProperties: ModelElement<DXM.BorderBoxProperties>
{
  public BorderBoxProperties(): base(){ }
  
  public BorderBoxProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BorderBoxProperties(DXM.BorderBoxProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Hide Top Edge.
  /// </summary>
  [DataMember]
  public DMM.HideTop? HideTop
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.HideTop>();
      if (element != null)
        return HideTopConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.HideTop>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HideTopConverter.CreateOpenXmlElement<DXM.HideTop>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Hide Bottom Edge.
  /// </summary>
  [DataMember]
  public DMM.HideBottom? HideBottom
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.HideBottom>();
      if (element != null)
        return HideBottomConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.HideBottom>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HideBottomConverter.CreateOpenXmlElement<DXM.HideBottom>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Hide Left Edge.
  /// </summary>
  [DataMember]
  public DMM.HideLeft? HideLeft
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.HideLeft>();
      if (element != null)
        return HideLeftConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.HideLeft>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HideLeftConverter.CreateOpenXmlElement<DXM.HideLeft>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Hide Right Edge.
  /// </summary>
  [DataMember]
  public DMM.HideRight? HideRight
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.HideRight>();
      if (element != null)
        return HideRightConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.HideRight>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HideRightConverter.CreateOpenXmlElement<DXM.HideRight>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Border Box Strikethrough Horizontal.
  /// </summary>
  [DataMember]
  public DMM.StrikeHorizontal? StrikeHorizontal
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.StrikeHorizontal>();
      if (element != null)
        return StrikeHorizontalConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.StrikeHorizontal>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StrikeHorizontalConverter.CreateOpenXmlElement<DXM.StrikeHorizontal>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Border Box Strikethrough Vertical.
  /// </summary>
  [DataMember]
  public DMM.StrikeVertical? StrikeVertical
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.StrikeVertical>();
      if (element != null)
        return StrikeVerticalConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.StrikeVertical>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StrikeVerticalConverter.CreateOpenXmlElement<DXM.StrikeVertical>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Border Box Strikethrough Bottom-Left to Top-Right.
  /// </summary>
  [DataMember]
  public DMM.StrikeBottomLeftToTopRight? StrikeBottomLeftToTopRight
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.StrikeBottomLeftToTopRight>();
      if (element != null)
        return StrikeBottomLeftToTopRightConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.StrikeBottomLeftToTopRight>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StrikeBottomLeftToTopRightConverter.CreateOpenXmlElement<DXM.StrikeBottomLeftToTopRight>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Border Box Strikethrough Top-Left to Bottom-Right.
  /// </summary>
  [DataMember]
  public DMM.StrikeTopLeftToBottomRight? StrikeTopLeftToBottomRight
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.StrikeTopLeftToBottomRight>();
      if (element != null)
        return StrikeTopLeftToBottomRightConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.StrikeTopLeftToBottomRight>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StrikeTopLeftToBottomRightConverter.CreateOpenXmlElement<DXM.StrikeTopLeftToBottomRight>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ControlProperties.
  /// </summary>
  [DataMember]
  public DMM.ControlProperties? ControlProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.ControlProperties>();
      if (element != null)
        return ControlPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.ControlProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ControlPropertiesConverter.CreateOpenXmlElement<DXM.ControlProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
