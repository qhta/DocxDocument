namespace DocumentModel.Drawings;


/// <summary>
///   Defines the SignatureLine Class.
/// </summary>
public partial class SignatureLine: ModelElement<DXO13D.SignatureLine>
{
  public SignatureLine(): base(){ }
  
  public SignatureLine(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SignatureLine(DXO13D.SignatureLine openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   isSignatureLine, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public Boolean? IsSignatureLine
  {
    get => _Element?.IsSignatureLine?.Value;
    set => _ExistingElement.IsSignatureLine = value;
  }
  
  
  /// <summary>
  ///   id, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? Id
  {
    get => HexIntConverter.GetValue(_Element?.Id);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   provId, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? ProviderId
  {
    get => HexIntConverter.GetValue(_Element?.ProviderId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   signingInstructionsSet, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public Boolean? SigningInstructionsSet
  {
    get => _Element?.SigningInstructionsSet?.Value;
    set => _ExistingElement.SigningInstructionsSet = value;
  }
  
  
  /// <summary>
  ///   allowComments, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public Boolean? AllowComments
  {
    get => _Element?.AllowComments?.Value;
    set => _ExistingElement.AllowComments = value;
  }
  
  
  /// <summary>
  ///   showSignDate, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public Boolean? ShowSignDate
  {
    get => _Element?.ShowSignDate?.Value;
    set => _ExistingElement.ShowSignDate = value;
  }
  
  
  /// <summary>
  ///   suggestedSigner, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? SuggestedSigner
  {
    get => _Element?.SuggestedSigner;
    set => _ExistingElement.SuggestedSigner = value;
  }
  
  
  /// <summary>
  ///   suggestedSigner2, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? SuggestedSigner2
  {
    get => _Element?.SuggestedSigner2;
    set => _ExistingElement.SuggestedSigner2 = value;
  }
  
  
  /// <summary>
  ///   suggestedSignerEmail, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? SuggestedSignerEmail
  {
    get => _Element?.SuggestedSignerEmail;
    set => _ExistingElement.SuggestedSignerEmail = value;
  }
  
  
  /// <summary>
  ///   signingInstructions, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? SigningInstructions
  {
    get => _Element?.SigningInstructions;
    set => _ExistingElement.SigningInstructions = value;
  }
  
  
  /// <summary>
  ///   addlXml, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? AdditionalXml
  {
    get => _Element?.AdditionalXml;
    set => _ExistingElement.AdditionalXml = value;
  }
  
  
  /// <summary>
  ///   sigProvUrl, this property is only available in Office 2013 and later.
  /// </summary>
  [DataMember]
  public String? SignatureProviderUrl
  {
    get => _Element?.SignatureProviderUrl;
    set => _ExistingElement.SignatureProviderUrl = value;
  }
  
}
