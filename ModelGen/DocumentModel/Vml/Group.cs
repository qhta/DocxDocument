namespace DocumentModel.Vml;


/// <summary>
///   Shape Group.
/// </summary>
public partial class Group: ModelElement<DXV.Group>
{
  public Group(): base(){ }
  
  public Group(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Group(DXV.Group openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  [DataMember]
  public String? Id
  {
    get => _Element?.Id;
    set => _ExistingElement.Id = value;
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
  ///   spid
  /// </summary>
  [DataMember]
  public String? OptionalString
  {
    get => _Element?.OptionalString;
    set => _ExistingElement.OptionalString = value;
  }
  
  
  /// <summary>
  ///   oned
  /// </summary>
  [DataMember]
  public Boolean? Oned
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   regroupid
  /// </summary>
  [DataMember]
  public Int64? RegroupId
  {
    get => _Element?.RegroupId?.Value;
    set => _ExistingElement.RegroupId = value;
  }
  
  
  /// <summary>
  ///   doubleclicknotify
  /// </summary>
  [DataMember]
  public Boolean? DoubleClickNotify
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   button
  /// </summary>
  [DataMember]
  public Boolean? Button
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   userhidden
  /// </summary>
  [DataMember]
  public Boolean? UserHidden
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   bullet
  /// </summary>
  [DataMember]
  public Boolean? Bullet
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   hr
  /// </summary>
  [DataMember]
  public Boolean? Horizontal
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   hrstd
  /// </summary>
  [DataMember]
  public Boolean? HorizontalStandard
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   hrnoshade
  /// </summary>
  [DataMember]
  public Boolean? HorizontalNoShade
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   hrpct
  /// </summary>
  [DataMember]
  public Single? HorizontalPercentage
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Single]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Single]");
  }
  
  
  /// <summary>
  ///   allowincell
  /// </summary>
  [DataMember]
  public Boolean? AllowInCell
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   allowoverlap
  /// </summary>
  [DataMember]
  public Boolean? AllowOverlap
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   userdrawn
  /// </summary>
  [DataMember]
  public Boolean? UserDrawn
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   dgmlayout
  /// </summary>
  [DataMember]
  public Int64? DiagramLayout
  {
    get => _Element?.DiagramLayout?.Value;
    set => _ExistingElement.DiagramLayout = value;
  }
  
  
  /// <summary>
  ///   dgmnodekind
  /// </summary>
  [DataMember]
  public Int64? DiagramNodeKind
  {
    get => _Element?.DiagramNodeKind?.Value;
    set => _ExistingElement.DiagramNodeKind = value;
  }
  
  
  /// <summary>
  ///   dgmlayoutmru
  /// </summary>
  [DataMember]
  public Int64? DiagramLayoutMostRecentUsed
  {
    get => _Element?.DiagramLayoutMostRecentUsed?.Value;
    set => _ExistingElement.DiagramLayoutMostRecentUsed = value;
  }
  
  
  /// <summary>
  ///   Encoded Package
  /// </summary>
  [DataMember]
  public DM.Base64Binary? Gfxdata
  {
    get => Base64BinaryConverter.GetValue(_Element?.Gfxdata);
    set => _ExistingElement.Gfxdata = Base64BinaryConverter.CreateBase64BinaryValue(value);
  }
  
  
  /// <summary>
  ///   Table Properties
  /// </summary>
  [DataMember]
  public String? TableProperties
  {
    get => _Element?.TableProperties;
    set => _ExistingElement.TableProperties = value;
  }
  
  
  /// <summary>
  ///   Table Row Height Limits
  /// </summary>
  [DataMember]
  public String? TableLimits
  {
    get => _Element?.TableLimits;
    set => _ExistingElement.TableLimits = value;
  }
  
}
