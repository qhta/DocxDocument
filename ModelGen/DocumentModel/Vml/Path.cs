namespace DocumentModel.Vml;


/// <summary>
///   Defines the Path Class.
/// </summary>
public partial class Path: ModelElement<DXV.Path>
{
  public Path(): base(){ }
  
  public Path(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Path(DXV.Path openXmlElement): base(openXmlElement) { }
  
  
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
  ///   Path Definition
  /// </summary>
  [DataMember]
  public String? Value
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Value);
    }
    set
    {
      _ExistingElement.Value = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Limo Stretch Point
  /// </summary>
  [DataMember]
  public String? Limo
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Limo);
    }
    set
    {
      _ExistingElement.Limo = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Text Box Bounding Box
  /// </summary>
  [DataMember]
  public String? TextboxRectangle
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.TextboxRectangle);
    }
    set
    {
      _ExistingElement.TextboxRectangle = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Shape Fill Toggle
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? AllowFill
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
  ///   Stroke Toggle
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? AllowStroke
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
  ///   Shadow Toggle
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? AllowShading
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
  ///   Arrowhead Display Toggle
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? ShowArrowhead
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
  ///   Gradient Shape Toggle
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? AllowGradientShape
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
  ///   Text Path Toggle
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? AllowTextPath
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
  ///   Inset Stroke From Path Flag
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? AllowInsetPen
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
  ///   Connection Points
  /// </summary>
  [DataMember]
  public String? ConnectionPoints
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.ConnectionPoints);
    }
    set
    {
      _ExistingElement.ConnectionPoints = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Connection Point Connect Angles
  /// </summary>
  [DataMember]
  public String? ConnectAngles
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.ConnectAngles);
    }
    set
    {
      _ExistingElement.ConnectAngles = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Extrusion Toggle
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? AllowExtrusion
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
  
}
