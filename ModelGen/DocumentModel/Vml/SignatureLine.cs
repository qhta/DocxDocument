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
    get
    {
      return _Element?.IsSignatureLine?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.IsSignatureLine = value;
      else
        _ExistingElement.IsSignatureLine = null;
    }
  }
  
  
  /// <summary>
  ///   Unique ID
  /// </summary>
  [DataMember]
  public String? Id
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Id);
    }
    set
    {
      _ExistingElement.Id = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Signature Provider ID
  /// </summary>
  [DataMember]
  public String? ProviderId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.ProviderId);
    }
    set
    {
      _ExistingElement.ProviderId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Use Signing Instructions Flag
  /// </summary>
  [DataMember]
  public Boolean? SigningInstructionsSet
  {
    get
    {
      return _Element?.SigningInstructionsSet?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.SigningInstructionsSet = value;
      else
        _ExistingElement.SigningInstructionsSet = null;
    }
  }
  
  
  /// <summary>
  ///   User-specified Comments Flag
  /// </summary>
  [DataMember]
  public Boolean? AllowComments
  {
    get
    {
      return _Element?.AllowComments?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.AllowComments = value;
      else
        _ExistingElement.AllowComments = null;
    }
  }
  
  
  /// <summary>
  ///   Show Signed Date Flag
  /// </summary>
  [DataMember]
  public Boolean? ShowSignDate
  {
    get
    {
      return _Element?.ShowSignDate?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.ShowSignDate = value;
      else
        _ExistingElement.ShowSignDate = null;
    }
  }
  
  
  /// <summary>
  ///   Suggested Signer Line 1
  /// </summary>
  [DataMember]
  public String? SuggestedSigner
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.SuggestedSigner);
    }
    set
    {
      _ExistingElement.SuggestedSigner = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Suggested Signer Line 2
  /// </summary>
  [DataMember]
  public String? SuggestedSigner2
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.SuggestedSigner2);
    }
    set
    {
      _ExistingElement.SuggestedSigner2 = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Suggested Signer E-mail Address
  /// </summary>
  [DataMember]
  public String? SuggestedSignerEmail
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.SuggestedSignerEmail);
    }
    set
    {
      _ExistingElement.SuggestedSignerEmail = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Instructions for Signing
  /// </summary>
  [DataMember]
  public String? SigningInstructions
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.SigningInstructions);
    }
    set
    {
      _ExistingElement.SigningInstructions = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Additional Signature Information
  /// </summary>
  [DataMember]
  public String? AdditionalXml
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.AdditionalXml);
    }
    set
    {
      _ExistingElement.AdditionalXml = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Signature Provider Download URL
  /// </summary>
  [DataMember]
  public String? SignatureProviderUrl
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.SignatureProviderUrl);
    }
    set
    {
      _ExistingElement.SignatureProviderUrl = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
