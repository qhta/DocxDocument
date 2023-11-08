namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the ValueColors Class.
/// </summary>
public partial class ValueColors: ModelElement<DXO16DCD.ValueColors>
{
  public ValueColors(): base(){ }
  
  public ValueColors(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ValueColors(DXO16DCD.ValueColors openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   MinColorSolidColorFillProperties.
  /// </summary>
  [DataMember]
  public DMDCD16.MinColorSolidColorFillProperties? MinColorSolidColorFillProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.MinColorSolidColorFillProperties>();
      if (element != null)
        return MinColorSolidColorFillPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.MinColorSolidColorFillProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MinColorSolidColorFillPropertiesConverter.CreateOpenXmlElement<DXO16DCD.MinColorSolidColorFillProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   MidColorSolidColorFillProperties.
  /// </summary>
  [DataMember]
  public DMDCD16.MidColorSolidColorFillProperties? MidColorSolidColorFillProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.MidColorSolidColorFillProperties>();
      if (element != null)
        return MidColorSolidColorFillPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.MidColorSolidColorFillProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MidColorSolidColorFillPropertiesConverter.CreateOpenXmlElement<DXO16DCD.MidColorSolidColorFillProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   MaxColorSolidColorFillProperties.
  /// </summary>
  [DataMember]
  public DMDCD16.MaxColorSolidColorFillProperties? MaxColorSolidColorFillProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.MaxColorSolidColorFillProperties>();
      if (element != null)
        return MaxColorSolidColorFillPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.MaxColorSolidColorFillProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MaxColorSolidColorFillPropertiesConverter.CreateOpenXmlElement<DXO16DCD.MaxColorSolidColorFillProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
