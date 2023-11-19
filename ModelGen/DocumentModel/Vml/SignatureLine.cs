namespace DocumentModel.Vml;


/// <summary>
///   Digital Signature Line.
/// </summary>
public partial class SignatureLine: ModelElement<DXVO.SignatureLine>
{
  public SignatureLine(): base(){ }
  
  public SignatureLine(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SignatureLine(DXVO.SignatureLine openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Signature Line Flag
  /// </summary>
  [DataMember]
  public Boolean? IsSignatureLine
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Unique ID
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? Id
  {
    get => HexIntConverter.GetValue(_Element?.Id);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Signature Provider ID
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? ProviderId
  {
    get => HexIntConverter.GetValue(_Element?.ProviderId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Use Signing Instructions Flag
  /// </summary>
  [DataMember]
  public Boolean? SigningInstructionsSet
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   User-specified Comments Flag
  /// </summary>
  [DataMember]
  public Boolean? AllowComments
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Show Signed Date Flag
  /// </summary>
  [DataMember]
  public Boolean? ShowSignDate
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Suggested Signer Line 1
  /// </summary>
  [DataMember]
  public String? SuggestedSigner
  {
    get => _Element?.SuggestedSigner;
    set => _ExistingElement.SuggestedSigner = value;
  }
  
  
  /// <summary>
  ///   Suggested Signer Line 2
  /// </summary>
  [DataMember]
  public String? SuggestedSigner2
  {
    get => _Element?.SuggestedSigner2;
    set => _ExistingElement.SuggestedSigner2 = value;
  }
  
  
  /// <summary>
  ///   Suggested Signer E-mail Address
  /// </summary>
  [DataMember]
  public String? SuggestedSignerEmail
  {
    get => _Element?.SuggestedSignerEmail;
    set => _ExistingElement.SuggestedSignerEmail = value;
  }
  
  
  /// <summary>
  ///   Instructions for Signing
  /// </summary>
  [DataMember]
  public String? SigningInstructions
  {
    get => _Element?.SigningInstructions;
    set => _ExistingElement.SigningInstructions = value;
  }
  
  
  /// <summary>
  ///   Additional Signature Information
  /// </summary>
  [DataMember]
  public String? AdditionalXml
  {
    get => _Element?.AdditionalXml;
    set => _ExistingElement.AdditionalXml = value;
  }
  
  
  /// <summary>
  ///   Signature Provider Download URL
  /// </summary>
  [DataMember]
  public String? SignatureProviderUrl
  {
    get => _Element?.SignatureProviderUrl;
    set => _ExistingElement.SignatureProviderUrl = value;
  }
  
}
