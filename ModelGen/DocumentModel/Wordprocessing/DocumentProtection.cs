namespace DocumentModel.Wordprocessing;


/// <summary>
///   Document Editing Restrictions.
/// </summary>
public partial class DocumentProtection: ModelElement<DXW.DocumentProtection>
{
  public DocumentProtection(): base(){ }
  
  public DocumentProtection(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DocumentProtection(DXW.DocumentProtection openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Only Allow Formatting With Unlocked Styles
  /// </summary>
  [DataMember]
  public Boolean? Formatting
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.Formatting);
    }
    set
    {
      _ExistingElement.Formatting = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   Enforce Document Protection Settings
  /// </summary>
  [DataMember]
  public Boolean? Enforcement
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.Enforcement);
    }
    set
    {
      _ExistingElement.Enforcement = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   Cryptographic Hashing Algorithm
  /// </summary>
  [DataMember]
  public Int32? CryptographicAlgorithmSid
  {
    get
    {
      return _Element?.CryptographicAlgorithmSid?.Value;
    }
    set
    {
      _ExistingElement.CryptographicAlgorithmSid = value;
    }
  }
  
  
  /// <summary>
  ///   Iterations to Run Hashing Algorithm
  /// </summary>
  [DataMember]
  public UInt32? CryptographicSpinCount
  {
    get
    {
      return _Element?.CryptographicSpinCount?.Value;
    }
    set
    {
      _ExistingElement.CryptographicSpinCount = value;
    }
  }
  
  
  /// <summary>
  ///   Cryptographic Provider
  /// </summary>
  [DataMember]
  public String? CryptographicProvider
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.CryptographicProvider);
    }
    set
    {
      _ExistingElement.CryptographicProvider = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Cryptographic Algorithm Extensibility
  /// </summary>
  [DataMember]
  public DM.HexBinary? AlgorithmIdExtensibility
  {
    get
    {
      if (_Element?.AlgorithmIdExtensibility?.Value != null)
        return HexIntConverter.GetValue(_Element?.AlgorithmIdExtensibility.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.AlgorithmIdExtensibility = value.ToString();
      else
        _ExistingElement.AlgorithmIdExtensibility = null;
    }
  }
  
  
  /// <summary>
  ///   Algorithm Extensibility Source
  /// </summary>
  [DataMember]
  public String? AlgorithmIdExtensibilitySource
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.AlgorithmIdExtensibilitySource);
    }
    set
    {
      _ExistingElement.AlgorithmIdExtensibilitySource = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Cryptographic Provider Type Extensibility
  /// </summary>
  [DataMember]
  public DM.HexBinary? CryptographicProviderTypeExtensibility
  {
    get
    {
      if (_Element?.CryptographicProviderTypeExtensibility?.Value != null)
        return HexIntConverter.GetValue(_Element?.CryptographicProviderTypeExtensibility.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.CryptographicProviderTypeExtensibility = value.ToString();
      else
        _ExistingElement.CryptographicProviderTypeExtensibility = null;
    }
  }
  
  
  /// <summary>
  ///   Provider Type Extensibility Source
  /// </summary>
  [DataMember]
  public String? CryptographicProviderTypeExtSource
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.CryptographicProviderTypeExtSource);
    }
    set
    {
      _ExistingElement.CryptographicProviderTypeExtSource = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Password Hash
  /// </summary>
  [DataMember]
  public DM.Base64Binary? Hash
  {
    get
    {
      return Base64BinaryConverter.GetValue(_Element?.Hash);
    }
    set
    {
      _ExistingElement.Hash = Base64BinaryConverter.CreateBase64BinaryValue(value);
    }
  }
  
  
  /// <summary>
  ///   Salt for Password Verifier
  /// </summary>
  [DataMember]
  public DM.Base64Binary? Salt
  {
    get
    {
      return Base64BinaryConverter.GetValue(_Element?.Salt);
    }
    set
    {
      _ExistingElement.Salt = Base64BinaryConverter.CreateBase64BinaryValue(value);
    }
  }
  
  
  /// <summary>
  ///   algorithmName, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? AlgorithmName
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.AlgorithmName);
    }
    set
    {
      _ExistingElement.AlgorithmName = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   hashValue, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public DM.Base64Binary? HashValue
  {
    get
    {
      return Base64BinaryConverter.GetValue(_Element?.HashValue);
    }
    set
    {
      _ExistingElement.HashValue = Base64BinaryConverter.CreateBase64BinaryValue(value);
    }
  }
  
  
  /// <summary>
  ///   saltValue, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public DM.Base64Binary? SaltValue
  {
    get
    {
      return Base64BinaryConverter.GetValue(_Element?.SaltValue);
    }
    set
    {
      _ExistingElement.SaltValue = Base64BinaryConverter.CreateBase64BinaryValue(value);
    }
  }
  
  
  /// <summary>
  ///   spinCount, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? SpinCount
  {
    get
    {
      return _Element?.SpinCount?.Value;
    }
    set
    {
      _ExistingElement.SpinCount = value;
    }
  }
  
}
