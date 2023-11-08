namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Defines the Picture Class.
/// </summary>
public partial class Picture: ModelElement<DXDCD.Picture>
{
  public Picture(): base(){ }
  
  public Picture(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Picture(DXDCD.Picture openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Reference to Custom Function
  /// </summary>
  [DataMember]
  public String? Macro
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Macro);
    }
    set
    {
      _ExistingElement.Macro = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Publish to Server
  /// </summary>
  [DataMember]
  public Boolean? Published
  {
    get
    {
      return _Element?.Published?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Published = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.Published = null;
    }
  }
  
  
  /// <summary>
  ///   Non-Visual Picture Properties.
  /// </summary>
  [DataMember]
  public DMDCD.NonVisualPictureProperties? NonVisualPictureProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDCD.NonVisualPictureProperties>();
      if (element != null)
        return NonVisualPicturePropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDCD.NonVisualPictureProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NonVisualPicturePropertiesConverter.CreateOpenXmlElement<DXDCD.NonVisualPictureProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Picture Fill.
  /// </summary>
  [DataMember]
  public DMDCD.BlipFill? BlipFill
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDCD.BlipFill>();
      if (element != null)
        return BlipFillConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDCD.BlipFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BlipFillConverter.CreateOpenXmlElement<DXDCD.BlipFill>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  [DataMember]
  public DMDCD.ShapeProperties? ShapeProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDCD.ShapeProperties>();
      if (element != null)
        return ShapePropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDCD.ShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapePropertiesConverter.CreateOpenXmlElement<DXDCD.ShapeProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Style.
  /// </summary>
  [DataMember]
  public DMDCD.Style? Style
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDCD.Style>();
      if (element != null)
        return StyleConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDCD.Style>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StyleConverter.CreateOpenXmlElement<DXDCD.Style>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
