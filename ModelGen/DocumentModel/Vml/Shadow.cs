namespace DocumentModel.Vml;


/// <summary>
///   Defines the Shadow Class.
/// </summary>
public partial class Shadow: ModelElement<DXV.Shadow>
{
  public Shadow(): base(){ }
  
  public Shadow(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Shadow(DXV.Shadow openXmlElement): base(openXmlElement) { }
  
  
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
  ///   Shadow Toggle
  /// </summary>
  [DataMember]
  public Boolean? On
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Shadow Transparency
  /// </summary>
  [DataMember]
  public Boolean? Obscured
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Shadow Primary Color
  /// </summary>
  [DataMember]
  public String? Color
  {
    get => _Element?.Color;
    set => _ExistingElement.Color = value;
  }
  
  
  /// <summary>
  ///   Shadow Opacity
  /// </summary>
  [DataMember]
  public String? Opacity
  {
    get => _Element?.Opacity;
    set => _ExistingElement.Opacity = value;
  }
  
  
  /// <summary>
  ///   Shadow Primary Offset
  /// </summary>
  [DataMember]
  public String? Offset
  {
    get => _Element?.Offset;
    set => _ExistingElement.Offset = value;
  }
  
  
  /// <summary>
  ///   Shadow Secondary Color
  /// </summary>
  [DataMember]
  public String? Color2
  {
    get => _Element?.Color2;
    set => _ExistingElement.Color2 = value;
  }
  
  
  /// <summary>
  ///   Shadow Secondary Offset
  /// </summary>
  [DataMember]
  public String? Offset2
  {
    get => _Element?.Offset2;
    set => _ExistingElement.Offset2 = value;
  }
  
  
  /// <summary>
  ///   Shadow Origin
  /// </summary>
  [DataMember]
  public String? Origin
  {
    get => _Element?.Origin;
    set => _ExistingElement.Origin = value;
  }
  
  
  /// <summary>
  ///   Shadow Perspective Matrix
  /// </summary>
  [DataMember]
  public String? Matrix
  {
    get => _Element?.Matrix;
    set => _ExistingElement.Matrix = value;
  }
  
}
