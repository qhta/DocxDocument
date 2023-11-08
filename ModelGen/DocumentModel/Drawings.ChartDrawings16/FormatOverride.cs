namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the FormatOverride Class.
/// </summary>
public partial class FormatOverride: ModelElement<DXO16DCD.FormatOverride>
{
  public FormatOverride(): base(){ }
  
  public FormatOverride(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FormatOverride(DXO16DCD.FormatOverride openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   idx, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public UInt32? Idx
  {
    get
    {
      return _Element?.Idx?.Value;
    }
    set
    {
      _ExistingElement.Idx = value;
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
