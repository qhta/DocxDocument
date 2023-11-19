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
  public DocumentModel.HexInt? Id
  {
    get => HexIntConverter.GetValue(_Element?.Id);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Stroke Toggle
  /// </summary>
  [DataMember]
  public Boolean? On
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Stroke Weight
  /// </summary>
  [DataMember]
  public String? Weight
  {
    get => _Element?.Weight;
    set => _ExistingElement.Weight = value;
  }
  
  
  /// <summary>
  ///   Stroke Color
  /// </summary>
  [DataMember]
  public String? Color
  {
    get => _Element?.Color;
    set => _ExistingElement.Color = value;
  }
  
  
  /// <summary>
  ///   Stroke Opacity
  /// </summary>
  [DataMember]
  public String? Opacity
  {
    get => _Element?.Opacity;
    set => _ExistingElement.Opacity = value;
  }
  
  
  /// <summary>
  ///   Miter Joint Limit
  /// </summary>
  [DataMember]
  public String? Miterlimit
  {
    get => _Element?.Miterlimit;
    set => _ExistingElement.Miterlimit = value;
  }
  
  
  /// <summary>
  ///   Stroke Dash Pattern
  /// </summary>
  [DataMember]
  public String? DashStyle
  {
    get => _Element?.DashStyle;
    set => _ExistingElement.DashStyle = value;
  }
  
  
  /// <summary>
  ///   Stroke Image Location
  /// </summary>
  [DataMember]
  public String? Source
  {
    get => _Element?.Source;
    set => _ExistingElement.Source = value;
  }
  
  
  /// <summary>
  ///   Stroke Image Size
  /// </summary>
  [DataMember]
  public String? ImageSize
  {
    get => _Element?.ImageSize;
    set => _ExistingElement.ImageSize = value;
  }
  
  
  /// <summary>
  ///   Stoke Image Alignment
  /// </summary>
  [DataMember]
  public Boolean? ImageAlignShape
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Stroke Alternate Pattern Color
  /// </summary>
  [DataMember]
  public String? Color2
  {
    get => _Element?.Color2;
    set => _ExistingElement.Color2 = value;
  }
  
  
  /// <summary>
  ///   Original Image Reference
  /// </summary>
  [DataMember]
  public String? Href
  {
    get => _Element?.Href;
    set => _ExistingElement.Href = value;
  }
  
  
  /// <summary>
  ///   Alternate Image Reference
  /// </summary>
  [DataMember]
  public String? AlternateImageReference
  {
    get => _Element?.AlternateImageReference;
    set => _ExistingElement.AlternateImageReference = value;
  }
  
  
  /// <summary>
  ///   Stroke Title
  /// </summary>
  [DataMember]
  public String? Title
  {
    get => _Element?.Title;
    set => _ExistingElement.Title = value;
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
  ///   Relationship
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? RelationshipId
  {
    get => HexIntConverter.GetValue(_Element?.RelationshipId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Inset Border From Path
  /// </summary>
  [DataMember]
  public Boolean? Insetpen
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   LeftStroke.
  /// </summary>
  [DataMember]
  public DMVML.LeftStroke? LeftStroke
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Vml.Office.StrokeChildType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Vml.Office.StrokeChildType");
  }
  
  
  /// <summary>
  ///   TopStroke.
  /// </summary>
  [DataMember]
  public DMVML.TopStroke? TopStroke
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Vml.Office.StrokeChildType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Vml.Office.StrokeChildType");
  }
  
  
  /// <summary>
  ///   RightStroke.
  /// </summary>
  [DataMember]
  public DMVML.RightStroke? RightStroke
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Vml.Office.StrokeChildType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Vml.Office.StrokeChildType");
  }
  
  
  /// <summary>
  ///   BottomStroke.
  /// </summary>
  [DataMember]
  public DMVML.BottomStroke? BottomStroke
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Vml.Office.StrokeChildType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Vml.Office.StrokeChildType");
  }
  
  
  /// <summary>
  ///   ColumnStroke.
  /// </summary>
  [DataMember]
  public DMVML.ColumnStroke? ColumnStroke
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Vml.Office.StrokeChildType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Vml.Office.StrokeChildType");
  }
  
}
