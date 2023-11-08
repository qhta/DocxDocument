namespace DocumentModel.Word10;


/// <summary>
///   This element specifies the outline style to be applied to text. By default, text does not have outline.
/// </summary>
public partial class TextOutlineEffect: ModelElement<DXO10W.TextOutlineEffect>
{
  public TextOutlineEffect(): base(){ }
  
  public TextOutlineEffect(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextOutlineEffect(DXO10W.TextOutlineEffect openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   w, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? LineWidth
  {
    get
    {
      return _Element?.LineWidth?.Value;
    }
    set
    {
      _ExistingElement.LineWidth = value;
    }
  }
  
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
  
  [DataMember]
  public DMW10.PresetLineDashKind? PresetLineDashProperties
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.PresetLineDashValues, DMW10.PresetLineDashKind>(_ExistingElement.GetFirstChild<DXO10W.PresetLineDashProperties>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10W.PresetLineDashProperties>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.PresetLineDashValues, DMW10.PresetLineDashKind>(itemElement, (DMW10.PresetLineDashKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXO10W.PresetLineDashProperties, DocumentFormat.OpenXml.Office2010.Word.PresetLineDashValues, DMW10.PresetLineDashKind>((DMW10.PresetLineDashKind)value));
    }
  }
  
  [DataMember]
  public DMW10.RoundEmpty? RoundEmpty
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10W.RoundEmpty>();
      if (element != null)
        return RoundEmptyConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10W.RoundEmpty>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RoundEmptyConverter.CreateOpenXmlElement<DXO10W.RoundEmpty>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW10.BevelEmpty? BevelEmpty
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10W.BevelEmpty>();
      if (element != null)
        return BevelEmptyConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10W.BevelEmpty>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BevelEmptyConverter.CreateOpenXmlElement<DXO10W.BevelEmpty>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW10.LineJoinMiterProperties? LineJoinMiterProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10W.LineJoinMiterProperties>();
      if (element != null)
        return LineJoinMiterPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10W.LineJoinMiterProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LineJoinMiterPropertiesConverter.CreateOpenXmlElement<DXO10W.LineJoinMiterProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
