namespace DocumentModel.Vml;


/// <summary>
///   Defines the Callout Class.
/// </summary>
public partial class Callout: ModelElement<DXVO.Callout>
{
  public Callout(): base(){ }
  
  public Callout(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Callout(DXVO.Callout openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Callout toggle
  /// </summary>
  [DataMember]
  public Boolean? On
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Callout type
  /// </summary>
  [DataMember]
  public String? Type
  {
    get => _Element?.Type;
    set => _ExistingElement.Type = value;
  }
  
  
  /// <summary>
  ///   Callout gap
  /// </summary>
  [DataMember]
  public String? Gap
  {
    get => _Element?.Gap;
    set => _ExistingElement.Gap = value;
  }
  
  
  /// <summary>
  ///   Callout automatic drop toggle
  /// </summary>
  [DataMember]
  public Boolean? DropAuto
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Callout drop position
  /// </summary>
  [DataMember]
  public String? Drop
  {
    get => _Element?.Drop;
    set => _ExistingElement.Drop = value;
  }
  
  
  /// <summary>
  ///   Callout drop distance
  /// </summary>
  [DataMember]
  public String? Distance
  {
    get => _Element?.Distance;
    set => _ExistingElement.Distance = value;
  }
  
  
  /// <summary>
  ///   Callout length toggle
  /// </summary>
  [DataMember]
  public Boolean? LengthSpecified
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Callout length
  /// </summary>
  [DataMember]
  public String? Length
  {
    get => _Element?.Length;
    set => _ExistingElement.Length = value;
  }
  
  
  /// <summary>
  ///   Callout accent bar toggle
  /// </summary>
  [DataMember]
  public Boolean? AccentBar
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Callout text border toggle
  /// </summary>
  [DataMember]
  public Boolean? TextBorder
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Callout flip x
  /// </summary>
  [DataMember]
  public Boolean? MinusX
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Callout flip y
  /// </summary>
  [DataMember]
  public Boolean? MinusY
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
}
