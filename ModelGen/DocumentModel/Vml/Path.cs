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
  public Boolean? AllowFill
  {
    get
    {
      return _Element?.AllowFill?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.AllowFill = value;
      else
        _ExistingElement.AllowFill = null;
    }
  }
  
  
  /// <summary>
  ///   Stroke Toggle
  /// </summary>
  [DataMember]
  public Boolean? AllowStroke
  {
    get
    {
      return _Element?.AllowStroke?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.AllowStroke = value;
      else
        _ExistingElement.AllowStroke = null;
    }
  }
  
  
  /// <summary>
  ///   Shadow Toggle
  /// </summary>
  [DataMember]
  public Boolean? AllowShading
  {
    get
    {
      return _Element?.AllowShading?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.AllowShading = value;
      else
        _ExistingElement.AllowShading = null;
    }
  }
  
  
  /// <summary>
  ///   Arrowhead Display Toggle
  /// </summary>
  [DataMember]
  public Boolean? ShowArrowhead
  {
    get
    {
      return _Element?.ShowArrowhead?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.ShowArrowhead = value;
      else
        _ExistingElement.ShowArrowhead = null;
    }
  }
  
  
  /// <summary>
  ///   Gradient Shape Toggle
  /// </summary>
  [DataMember]
  public Boolean? AllowGradientShape
  {
    get
    {
      return _Element?.AllowGradientShape?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.AllowGradientShape = value;
      else
        _ExistingElement.AllowGradientShape = null;
    }
  }
  
  
  /// <summary>
  ///   Text Path Toggle
  /// </summary>
  [DataMember]
  public Boolean? AllowTextPath
  {
    get
    {
      return _Element?.AllowTextPath?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.AllowTextPath = value;
      else
        _ExistingElement.AllowTextPath = null;
    }
  }
  
  
  /// <summary>
  ///   Inset Stroke From Path Flag
  /// </summary>
  [DataMember]
  public Boolean? AllowInsetPen
  {
    get
    {
      return _Element?.AllowInsetPen?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.AllowInsetPen = value;
      else
        _ExistingElement.AllowInsetPen = null;
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
  public Boolean? AllowExtrusion
  {
    get
    {
      return _Element?.AllowExtrusion?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.AllowExtrusion = value;
      else
        _ExistingElement.AllowExtrusion = null;
    }
  }
  
}
