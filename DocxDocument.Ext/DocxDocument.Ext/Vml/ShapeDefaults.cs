namespace DocumentModel.Vml;

/// <summary>
/// This class specifies the defaults that are used when creating new shapes. These defaults are stored once per document.
/// </summary>
public partial class ShapeDefaults : IOpenXmlElementMappedObject
{
  public ShapeDefaults()
  {
    _Element = new DXVO.ShapeDefaults();
  }

  public ShapeDefaults(DX.OpenXmlElement openXmlElement)
  {
    _Element = (DXVO.ShapeDefaults)openXmlElement;
  }

  public OpenXmlElementType GetElement<OpenXmlElementType>() where OpenXmlElementType : DX.OpenXmlElement
  {
    if (_Element is OpenXmlElementType validTypeElement)
      return validTypeElement;
    throw new ArgumentException($"Only {_Element.GetType()} type supported in GetElement of {this.GetType()}");
  }

  public ShapeDefaults(DXVO.ShapeDefaults openXmlElement)
  {
    _Element = openXmlElement;
  }

  internal DXVO.ShapeDefaults _Element { get; private set; }

  /// <summary>
  /// Shape ID Optional Storage
  /// </summary>
  [DataMember]
  public long? MaxShapeId
  {
    get => _Element.MaxShapeId?.Value;
    set => _Element.MaxShapeId = value;
  }

  /// <summary>
  /// style
  /// </summary>
  [DataMember]
  public string? Style
  {
    get => _Element.Style?.Value;
    set => _Element.Style = value;
  }

  /// <summary>
  /// Shape Fill Toggle
  /// </summary>
  [DataMember]
  public bool? BeFilled
  {
    get => _Element.BeFilled?.Value;
    set => _Element.BeFilled = value;
  }

  /// <summary>
  /// Default Fill Color
  /// </summary>
  [DataMember]
  public string? FillColor
  {
    get => _Element.FillColor?.Value;
    set => _Element.FillColor = value;
  }

  /// <summary>
  /// Shape Stroke Toggle
  /// </summary>
  [DataMember]
  public bool? IsStroke
  {
    get => _Element.IsStroke?.Value;
    set => _Element.IsStroke = value;
  }

  /// <summary>
  /// Shape Stroke Color
  /// </summary>
  [DataMember]
  public string? StrokeColor
  {
    get => _Element.StrokeColor?.Value;
    set => _Element.StrokeColor = value;
  }

  /// <summary>
  /// Allow in Table Cell
  /// </summary>
  [DataMember]
  public bool? AllowInCell
  {
    get => _Element.AllowInCell?.Value;
    set => _Element.AllowInCell = value;
  }

  /// <summary>
  /// allowoverlap
  /// </summary>
  [DataMember]
  public bool? AllowOverlap
  {
    get => _Element.AllowOverlap?.Value;
    set => _Element.AllowOverlap = value;
  }

  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  [DataMember]
  public DXV.ExtensionHandlingBehaviorValues? Extension
  {
    get => _Element.Extension?.Value;
    set => _Element.Extension = value;
  }
}
