namespace DocumentModel.Math;


/// <summary>
///   Delimiter Properties.
/// </summary>
public partial class DelimiterProperties: ModelElement<DXM.DelimiterProperties>
{
  public DelimiterProperties(): base(){ }
  
  public DelimiterProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DelimiterProperties(DXM.DelimiterProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Delimiter Beginning Character.
  /// </summary>
  [DataMember]
  public DMM.BeginChar? BeginChar
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.BeginChar>();
      if (element != null)
        return BeginCharConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.BeginChar>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BeginCharConverter.CreateOpenXmlElement<DXM.BeginChar>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Delimiter Separator Character.
  /// </summary>
  [DataMember]
  public DMM.SeparatorChar? SeparatorChar
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.SeparatorChar>();
      if (element != null)
        return SeparatorCharConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.SeparatorChar>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SeparatorCharConverter.CreateOpenXmlElement<DXM.SeparatorChar>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Delimiter Ending Character.
  /// </summary>
  [DataMember]
  public DMM.EndChar? EndChar
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.EndChar>();
      if (element != null)
        return EndCharConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.EndChar>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EndCharConverter.CreateOpenXmlElement<DXM.EndChar>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Delimiter Grow.
  /// </summary>
  [DataMember]
  public DMM.GrowOperators? GrowOperators
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.GrowOperators>();
      if (element != null)
        return GrowOperatorsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.GrowOperators>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GrowOperatorsConverter.CreateOpenXmlElement<DXM.GrowOperators>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Shape (Delimiters).
  /// </summary>
  [DataMember]
  public DMM.ShapeDelimiterKind? Shape
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.ShapeDelimiterValues, DMM.ShapeDelimiterKind>(_ExistingElement.GetFirstChild<DXM.Shape>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.Shape>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.ShapeDelimiterValues, DMM.ShapeDelimiterKind>(itemElement, (DMM.ShapeDelimiterKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXM.Shape, DocumentFormat.OpenXml.Math.ShapeDelimiterValues, DMM.ShapeDelimiterKind>((DMM.ShapeDelimiterKind)value));
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
