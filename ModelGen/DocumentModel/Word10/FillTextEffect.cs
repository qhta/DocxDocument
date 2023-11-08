namespace DocumentModel.Word10;


/// <summary>
///   This element specifies the fill for text. By default, this element is absent. When this element is absent, the color of text is determined by the color element.
/// </summary>
public partial class FillTextEffect: ModelElement<DXO10W.FillTextEffect>
{
  public FillTextEffect(): base(){ }
  
  public FillTextEffect(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FillTextEffect(DXO10W.FillTextEffect openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   NoFillEmpty.
  /// </summary>
  [DataMember]
  public DMW10.NoFillEmpty? NoFillEmpty
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10W.NoFillEmpty>();
      if (element != null)
        return NoFillEmptyConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10W.NoFillEmpty>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NoFillEmptyConverter.CreateOpenXmlElement<DXO10W.NoFillEmpty>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   SolidColorFillProperties.
  /// </summary>
  [DataMember]
  public DMW10.SolidColorFillProperties? SolidColorFillProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10W.SolidColorFillProperties>();
      if (element != null)
        return SolidColorFillPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10W.SolidColorFillProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SolidColorFillPropertiesConverter.CreateOpenXmlElement<DXO10W.SolidColorFillProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   GradientFillProperties.
  /// </summary>
  [DataMember]
  public DMW10.GradientFillProperties? GradientFillProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10W.GradientFillProperties>();
      if (element != null)
        return GradientFillPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10W.GradientFillProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GradientFillPropertiesConverter.CreateOpenXmlElement<DXO10W.GradientFillProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
