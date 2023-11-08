namespace DocumentModel.Vml;


/// <summary>
///   Defines the Stroke Class.
/// </summary>
public partial class Stroke: ModelElement<DXV.Stroke>
{
  public Stroke(): base(){ }
  
  public Stroke(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Stroke(DXV.Stroke openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  [DataMember]
  public String? Id
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Id);
    }
    set
    {
      _ExistingElement.Id = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Stroke Toggle
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? On
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseValue,DocumentFormat.OpenXml.TrueFalseValue>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   Stroke Weight
  /// </summary>
  [DataMember]
  public String? Weight
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Weight);
    }
    set
    {
      _ExistingElement.Weight = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Stroke Color
  /// </summary>
  [DataMember]
  public String? Color
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Color);
    }
    set
    {
      _ExistingElement.Color = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Stroke Opacity
  /// </summary>
  [DataMember]
  public String? Opacity
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Opacity);
    }
    set
    {
      _ExistingElement.Opacity = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Miter Joint Limit
  /// </summary>
  [DataMember]
  public String? Miterlimit
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Miterlimit);
    }
    set
    {
      _ExistingElement.Miterlimit = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Stroke Dash Pattern
  /// </summary>
  [DataMember]
  public String? DashStyle
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.DashStyle);
    }
    set
    {
      _ExistingElement.DashStyle = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Stroke Image Location
  /// </summary>
  [DataMember]
  public String? Source
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Source);
    }
    set
    {
      _ExistingElement.Source = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Stroke Image Size
  /// </summary>
  [DataMember]
  public String? ImageSize
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.ImageSize);
    }
    set
    {
      _ExistingElement.ImageSize = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Stoke Image Alignment
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? ImageAlignShape
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseValue,DocumentFormat.OpenXml.TrueFalseValue>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   Stroke Alternate Pattern Color
  /// </summary>
  [DataMember]
  public String? Color2
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Color2);
    }
    set
    {
      _ExistingElement.Color2 = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Original Image Reference
  /// </summary>
  [DataMember]
  public String? Href
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Href);
    }
    set
    {
      _ExistingElement.Href = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Alternate Image Reference
  /// </summary>
  [DataMember]
  public String? AlternateImageReference
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.AlternateImageReference);
    }
    set
    {
      _ExistingElement.AlternateImageReference = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Stroke Title
  /// </summary>
  [DataMember]
  public String? Title
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Title);
    }
    set
    {
      _ExistingElement.Title = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Force Dashed Outline
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? ForceDash
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseValue,DocumentFormat.OpenXml.TrueFalseValue>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   Relationship
  /// </summary>
  [DataMember]
  public String? RelationshipId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.RelationshipId);
    }
    set
    {
      _ExistingElement.RelationshipId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Inset Border From Path
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? Insetpen
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseValue,DocumentFormat.OpenXml.TrueFalseValue>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   LeftStroke.
  /// </summary>
  [DataMember]
  public DMVML.LeftStroke? LeftStroke
  {
    get
    {
      var element = _Element?.GetFirstChild<DXVO.LeftStroke>();
      if (element != null)
        return LeftStrokeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXVO.LeftStroke>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LeftStrokeConverter.CreateOpenXmlElement<DXVO.LeftStroke>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   TopStroke.
  /// </summary>
  [DataMember]
  public DMVML.TopStroke? TopStroke
  {
    get
    {
      var element = _Element?.GetFirstChild<DXVO.TopStroke>();
      if (element != null)
        return TopStrokeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXVO.TopStroke>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TopStrokeConverter.CreateOpenXmlElement<DXVO.TopStroke>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   RightStroke.
  /// </summary>
  [DataMember]
  public DMVML.RightStroke? RightStroke
  {
    get
    {
      var element = _Element?.GetFirstChild<DXVO.RightStroke>();
      if (element != null)
        return RightStrokeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXVO.RightStroke>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RightStrokeConverter.CreateOpenXmlElement<DXVO.RightStroke>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   BottomStroke.
  /// </summary>
  [DataMember]
  public DMVML.BottomStroke? BottomStroke
  {
    get
    {
      var element = _Element?.GetFirstChild<DXVO.BottomStroke>();
      if (element != null)
        return BottomStrokeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXVO.BottomStroke>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BottomStrokeConverter.CreateOpenXmlElement<DXVO.BottomStroke>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ColumnStroke.
  /// </summary>
  [DataMember]
  public DMVML.ColumnStroke? ColumnStroke
  {
    get
    {
      var element = _Element?.GetFirstChild<DXVO.ColumnStroke>();
      if (element != null)
        return ColumnStrokeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXVO.ColumnStroke>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ColumnStrokeConverter.CreateOpenXmlElement<DXVO.ColumnStroke>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
