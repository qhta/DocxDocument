namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the ChartTitle Class.
/// </summary>
public partial class ChartTitle: ModelElement<DXO16DCD.ChartTitle>
{
  public ChartTitle(): base(){ }
  
  public ChartTitle(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ChartTitle(DXO16DCD.ChartTitle openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   overlay, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Boolean? Overlay
  {
    get
    {
      return _Element?.Overlay?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Overlay = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.Overlay = null;
    }
  }
  
  
  /// <summary>
  ///   Text.
  /// </summary>
  [DataMember]
  public DMDCD16.Text? Text
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.Text>();
      if (element != null)
        return TextConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.Text>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextConverter.CreateOpenXmlElement<DXO16DCD.Text>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  [DataMember]
  public DMDCD16.ShapeProperties? ShapeProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.ShapeProperties>();
      if (element != null)
        return ShapePropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.ShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapePropertiesConverter.CreateOpenXmlElement<DXO16DCD.ShapeProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   TxPrTextBody.
  /// </summary>
  [DataMember]
  public DMDCD16.TxPrTextBody? TxPrTextBody
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.TxPrTextBody>();
      if (element != null)
        return TxPrTextBodyConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.TxPrTextBody>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TxPrTextBodyConverter.CreateOpenXmlElement<DXO16DCD.TxPrTextBody>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [DataMember]
  public DMDCD16.ExtensionList? ExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.ExtensionList>();
      if (element != null)
        return ExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DXO16DCD.ExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
