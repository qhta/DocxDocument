namespace DocumentModel.Vml;

/// <summary>
/// This class specifies the defaults that are used when creating new shapes. These defaults are stored once per document.
/// </summary>
public partial class ShapeDefaults : ModelElement<DXVO.ShapeDefaults>
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public ShapeDefaults(): base(){ }

  public ShapeDefaults(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }

  public ShapeDefaults(DXVO.ShapeDefaults openXmlElement): base(openXmlElement) { } 
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

  /// <summary>
  /// Shape ID Optional Storage
  /// </summary>
  [DataMember]
  public long? MaxShapeId
  {
    get => _Element?.MaxShapeId?.Value;
    set => _ExistingElement.MaxShapeId = value;
  }

  /// <summary>
  /// style
  /// </summary>
  [DataMember]
  public string? Style
  {
    get => _Element?.Style?.Value;
    set => _ExistingElement.Style = value;
  }

  /// <summary>
  /// Shape Fill Toggle
  /// </summary>
  [DataMember]
  public bool? BeFilled
  {
    get => _Element?.BeFilled?.Value;
    set => _ExistingElement.BeFilled = value;
  }

  /// <summary>
  /// Default Fill Color
  /// </summary>
  [DataMember]
  public string? FillColor
  {
    get => _Element?.FillColor?.Value;
    set => _ExistingElement.FillColor = value;
  }

  /// <summary>
  /// Shape Stroke Toggle
  /// </summary>
  [DataMember]
  public bool? IsStroke
  {
    get => _Element?.IsStroke?.Value;
    set => _ExistingElement.IsStroke = value;
  }

  /// <summary>
  /// Shape Stroke Color
  /// </summary>
  [DataMember]
  public string? StrokeColor
  {
    get => _Element?.StrokeColor?.Value;
    set => _ExistingElement.StrokeColor = value;
  }

  /// <summary>
  /// Allow in Table Cell
  /// </summary>
  [DataMember]
  public bool? AllowInCell
  {
    get => _Element?.AllowInCell?.Value;
    set => _ExistingElement.AllowInCell = value;
  }

  /// <summary>
  /// allowoverlap
  /// </summary>
  [DataMember]
  public bool? AllowOverlap
  {
    get => _Element?.AllowOverlap?.Value;
    set => _ExistingElement.AllowOverlap = value;
  }

  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  [DataMember]
  public DMV.ExtensionHandlingBehaviorKind? Extension
  {
    get => _Element?.Extension?.GetEnumValue<DMV.ExtensionHandlingBehaviorKind, DXV.ExtensionHandlingBehaviorValues>();
    set => EVU.SetEnumValue<DMV.ExtensionHandlingBehaviorKind, DXV.ExtensionHandlingBehaviorValues>(_ExistingElement, nameof(Extension), value);
  }
}
