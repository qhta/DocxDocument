namespace DocumentModel.Vml;


/// <summary>
///   Defines the TextBox Class.
/// </summary>
public partial class TextBox: ModelElement<DXV.TextBox>
{
  public TextBox(): base(){ }
  
  public TextBox(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextBox(DXV.TextBox openXmlElement): base(openXmlElement) { }
  
  
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
  ///   Text Box Inset
  /// </summary>
  [DataMember]
  public String? Inset
  {
    get => _Element?.Inset;
    set => _ExistingElement.Inset = value;
  }
  
  
  /// <summary>
  ///   Text Box Single-Click Selection Toggle
  /// </summary>
  [DataMember]
  public Boolean? SingleClick
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  [DataMember]
  public DMW.TextBoxContent? TextBoxContent
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
