namespace DocumentModel.Vml;


/// <summary>
///   Shape Definition.
/// </summary>
public partial class Shape: ModelElement<DXV.Shape>
{
  public Shape(): base(){ }
  
  public Shape(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Shape(DXV.Shape openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? Id
  {
    get => HexIntConverter.GetValue(_Element?.Id);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Shape Styling Properties
  /// </summary>
  [DataMember]
  public String? Style
  {
    get => _Element?.Style;
    set => _ExistingElement.Style = value;
  }
  
  
  /// <summary>
  ///   Hyperlink Target
  /// </summary>
  [DataMember]
  public String? Href
  {
    get => _Element?.Href;
    set => _ExistingElement.Href = value;
  }
  
  
  /// <summary>
  ///   Hyperlink Display Target
  /// </summary>
  [DataMember]
  public String? Target
  {
    get => _Element?.Target;
    set => _ExistingElement.Target = value;
  }
  
  
  /// <summary>
  ///   CSS Reference
  /// </summary>
  [DataMember]
  public String? Class
  {
    get => _Element?.Class;
    set => _ExistingElement.Class = value;
  }
  
  
  /// <summary>
  ///   Shape Title
  /// </summary>
  [DataMember]
  public String? Title
  {
    get => _Element?.Title;
    set => _ExistingElement.Title = value;
  }
  
  
  /// <summary>
  ///   Alternate Text
  /// </summary>
  [DataMember]
  public String? Alternate
  {
    get => _Element?.Alternate;
    set => _ExistingElement.Alternate = value;
  }
  
  
  /// <summary>
  ///   Coordinate Space Size
  /// </summary>
  [DataMember]
  public String? CoordinateSize
  {
    get => _Element?.CoordinateSize;
    set => _ExistingElement.CoordinateSize = value;
  }
  
  
  /// <summary>
  ///   Coordinate Space Origin
  /// </summary>
  [DataMember]
  public String? CoordinateOrigin
  {
    get => _Element?.CoordinateOrigin;
    set => _ExistingElement.CoordinateOrigin = value;
  }
  
  
  /// <summary>
  ///   Shape Bounding Polygon
  /// </summary>
  [DataMember]
  public String? WrapCoordinates
  {
    get => _Element?.WrapCoordinates;
    set => _ExistingElement.WrapCoordinates = value;
  }
  
  
  /// <summary>
  ///   Print Toggle
  /// </summary>
  [DataMember]
  public Boolean? Print
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Optional String
  /// </summary>
  [DataMember]
  public String? OptionalString
  {
    get => _Element?.OptionalString;
    set => _ExistingElement.OptionalString = value;
  }
  
  
  /// <summary>
  ///   Shape Handle Toggle
  /// </summary>
  [DataMember]
  public Boolean? Oned
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Regroup ID
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? RegroupId
  {
    get => HexIntConverter.GetValue(_Element?.RegroupId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Double-click Notification Toggle
  /// </summary>
  [DataMember]
  public Boolean? DoubleClickNotify
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Button Behavior Toggle
  /// </summary>
  [DataMember]
  public Boolean? Button
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Hide Script Anchors
  /// </summary>
  [DataMember]
  public Boolean? UserHidden
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Graphical Bullet
  /// </summary>
  [DataMember]
  public Boolean? Bullet
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Horizontal Rule Toggle
  /// </summary>
  [DataMember]
  public Boolean? Horizontal
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Horizontal Rule Standard Display Toggle
  /// </summary>
  [DataMember]
  public Boolean? HorizontalStandard
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Horizontal Rule 3D Shading Toggle
  /// </summary>
  [DataMember]
  public Boolean? HorizontalNoShade
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Horizontal Rule Length Percentage
  /// </summary>
  [DataMember]
  public Single? HorizontalPercentage
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Single]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Single]");
  }
  
  
  /// <summary>
  ///   Allow in Table Cell
  /// </summary>
  [DataMember]
  public Boolean? AllowInCell
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Allow Shape Overlap
  /// </summary>
  [DataMember]
  public Boolean? AllowOverlap
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Exists In Master Slide
  /// </summary>
  [DataMember]
  public Boolean? UserDrawn
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Border Top Color
  /// </summary>
  [DataMember]
  public String? BorderTopColor
  {
    get => _Element?.BorderTopColor;
    set => _ExistingElement.BorderTopColor = value;
  }
  
  
  /// <summary>
  ///   Border Left Color
  /// </summary>
  [DataMember]
  public String? BorderLeftColor
  {
    get => _Element?.BorderLeftColor;
    set => _ExistingElement.BorderLeftColor = value;
  }
  
  
  /// <summary>
  ///   Bottom Border Color
  /// </summary>
  [DataMember]
  public String? BorderBottomColor
  {
    get => _Element?.BorderBottomColor;
    set => _ExistingElement.BorderBottomColor = value;
  }
  
  
  /// <summary>
  ///   Border Right Color
  /// </summary>
  [DataMember]
  public String? BorderRightColor
  {
    get => _Element?.BorderRightColor;
    set => _ExistingElement.BorderRightColor = value;
  }
  
  
  /// <summary>
  ///   Diagram Node Layout Identifier
  /// </summary>
  [DataMember]
  public Int64? DiagramLayout
  {
    get => _Element?.DiagramLayout?.Value;
    set => _ExistingElement.DiagramLayout = value;
  }
  
  
  /// <summary>
  ///   Diagram Node Identifier
  /// </summary>
  [DataMember]
  public Int64? DiagramNodeKind
  {
    get => _Element?.DiagramNodeKind?.Value;
    set => _ExistingElement.DiagramNodeKind = value;
  }
  
  
  /// <summary>
  ///   Diagram Node Recent Layout Identifier
  /// </summary>
  [DataMember]
  public Int64? DiagramLayoutMostRecentUsed
  {
    get => _Element?.DiagramLayoutMostRecentUsed?.Value;
    set => _ExistingElement.DiagramLayoutMostRecentUsed = value;
  }
  
  
  /// <summary>
  ///   Shape Fill Toggle
  /// </summary>
  [DataMember]
  public Boolean? Filled
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Fill Color
  /// </summary>
  [DataMember]
  public String? FillColor
  {
    get => _Element?.FillColor;
    set => _ExistingElement.FillColor = value;
  }
  
  
  /// <summary>
  ///   Shape Stroke Toggle
  /// </summary>
  [DataMember]
  public Boolean? Stroked
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Shape Stroke Color
  /// </summary>
  [DataMember]
  public String? StrokeColor
  {
    get => _Element?.StrokeColor;
    set => _ExistingElement.StrokeColor = value;
  }
  
  
  /// <summary>
  ///   Shape Stroke Weight
  /// </summary>
  [DataMember]
  public String? StrokeWeight
  {
    get => _Element?.StrokeWeight;
    set => _ExistingElement.StrokeWeight = value;
  }
  
  
  /// <summary>
  ///   Inset Border From Path
  /// </summary>
  [DataMember]
  public Boolean? InsetPen
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Optional Number
  /// </summary>
  [DataMember]
  public Int32? OptionalNumber
  {
    get => _Element?.OptionalNumber?.Value;
    set => _ExistingElement.OptionalNumber = value;
  }
  
  
  /// <summary>
  ///   Force Dashed Outline
  /// </summary>
  [DataMember]
  public Boolean? ForceDash
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Embedded Object Icon Toggle
  /// </summary>
  [DataMember]
  public Boolean? OleIcon
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Embedded Object Toggle
  /// </summary>
  [DataMember]
  public Boolean? Ole
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseBlankValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseBlankValue");
  }
  
  
  /// <summary>
  ///   Relative Resize Toggle
  /// </summary>
  [DataMember]
  public Boolean? PreferRelative
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Clip to Wrapping Polygon
  /// </summary>
  [DataMember]
  public Boolean? ClipToWrap
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Clipping Toggle
  /// </summary>
  [DataMember]
  public Boolean? Clip
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Shape Type Reference
  /// </summary>
  [DataMember]
  public String? Type
  {
    get => _Element?.Type;
    set => _ExistingElement.Type = value;
  }
  
  
  /// <summary>
  ///   Adjustment Parameters
  /// </summary>
  [DataMember]
  public String? Adjustment
  {
    get => _Element?.Adjustment;
    set => _ExistingElement.Adjustment = value;
  }
  
  
  /// <summary>
  ///   Edge Path
  /// </summary>
  [DataMember]
  public String? EdgePath
  {
    get => _Element?.EdgePath;
    set => _ExistingElement.EdgePath = value;
  }
  
  
  /// <summary>
  ///   Encoded Package
  /// </summary>
  [DataMember]
  public DM.Base64Binary? EncodedPackage
  {
    get => Base64BinaryConverter.GetValue(_Element?.EncodedPackage);
    set => _ExistingElement.EncodedPackage = Base64BinaryConverter.CreateBase64BinaryValue(value);
  }
  
  
  /// <summary>
  ///   Storage for Alternate Math Content
  /// </summary>
  [DataMember]
  public String? EquationXml
  {
    get => _Element?.EquationXml;
    set => _ExistingElement.EquationXml = value;
  }
  
}
