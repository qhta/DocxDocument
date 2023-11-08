namespace DocumentModel.Wordprocessing;


/// <summary>
///   Write Protection.
/// </summary>
public partial class WriteProtection: ModelElement<DXW.WriteProtection>
{
  public WriteProtection(): base(){ }
  
  public WriteProtection(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public WriteProtection(DXW.WriteProtection openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Recommend Write Protection in User Interface
  /// </summary>
  [DataMember]
  public Boolean? Recommended
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.Recommended);
    }
    set
    {
      _ExistingElement.Recommended = BooleanValueConverter.CreateOnOffValue(value);
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
        return HexIntConverter.GetValue(_ExistingElement.AlgorithmIdExtensibility.Value);
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
        return HexIntConverter.GetValue(_ExistingElement.CryptographicProviderTypeExtensibility.Value);
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
      if (_Element?.Hash?.Value != null)
        return Convert.FromBase64String(_ExistingElement.Hash.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.Hash = Convert.ToBase64String(value);
      else
        _ExistingElement.Hash = null;
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
      if (_Element?.Salt?.Value != null)
        return Convert.FromBase64String(_ExistingElement.Salt.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.Salt = Convert.ToBase64String(value);
      else
        _ExistingElement.Salt = null;
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
      if (_Element?.HashValue?.Value != null)
        return Convert.FromBase64String(_ExistingElement.HashValue.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.HashValue = Convert.ToBase64String(value);
      else
        _ExistingElement.HashValue = null;
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
      if (_Element?.SaltValue?.Value != null)
        return Convert.FromBase64String(_ExistingElement.SaltValue.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.SaltValue = Convert.ToBase64String(value);
      else
        _ExistingElement.SaltValue = null;
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
