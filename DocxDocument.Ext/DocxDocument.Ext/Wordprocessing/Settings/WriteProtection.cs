namespace DocumentModel.Wordprocessing;

/// <summary>
/// This class specifies the write protection settings which have been applied to a WordprocessingML document. 
/// Write protection refers to a mode in which the document's contents cannot be edited, 
/// and the document cannot be resaved using the same file name. 
/// This setting is independent of the documentProtection (§17.15.1.29) element, 
/// but like document protection, this setting is not intended as a security feature and can be ignored.
/// When present, the write protection shall result in one of two write protection behaviors:
/// <list type="bullet">
///   <item>
///     If the password attribute is present, or both attributes are omitted, 
///     then the application shall prompt for a password to exit write protection. 
///     If the supplied password does not match the hash value in this attribute, then write protection shall be enabled.
///   </item>
///   <item>
///    If only the recommended attribute is present, the application should provide user interface 
///    recommending that the user open this document in write protected state. 
///    If the user chooses to do so, the document shall be write protected, otherwise, it shall be opened fully editable.
///  </item>
/// </list>
/// If this element is omitted, then no write protection shall be applied to the current document.
/// </summary>
[DataContract]
public partial class WriteProtection : ModelElement<DXW.WriteProtection>
{
  public WriteProtection(): base(){ }

  public WriteProtection(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }

  public WriteProtection(DXW.WriteProtection openXmlElement): base(openXmlElement) { } 

  /// <summary>
  /// Recommend Write Protection in User Interface.
  /// </summary>
  [DataMember]
  public bool? Recommended
  {
    get => _Element.Recommended?.Value;
    set
    {
      if (value != null)
        _Element.Recommended = new DX.OnOffValue { Value = (bool)value };
      else
        _Element.Recommended = null;
    }
  }

  /// <summary>
  /// Cryptographic Provider Type.
  /// </summary>
  [DataMember]
  public DMW.CryptProviderKind? CryptographicProviderType
  {
    get => _Element.CryptographicProviderType?.GetEnumValue<DMW.CryptProviderKind, DXW.CryptProviderValues>();
    set => _Element.CryptographicProviderType = EVU.SetEnumValue<DMW.CryptProviderKind, DXW.CryptProviderValues>(value);
  }

  /// <summary>
  /// Cryptographic Algorithm Class.
  /// </summary>
  [DataMember]
  public DMW.CryptAlgorithmClassKind? CryptographicAlgorithmClass
  {
    get => _Element.CryptographicAlgorithmClass?.GetEnumValue<DMW.CryptAlgorithmClassKind, DXW.CryptAlgorithmClassValues>();
    set => _Element.CryptographicAlgorithmClass = EVU.SetEnumValue<DMW.CryptAlgorithmClassKind, DXW.CryptAlgorithmClassValues>(value);

  }

  /// <summary>
  /// Cryptographic Algorithm Type.
  /// </summary>
  [DataMember]
  public DMW.CryptAlgorithmKind? CryptographicAlgorithmType
  {
    get => _Element.CryptographicAlgorithmType?.GetEnumValue<DMW.CryptAlgorithmKind, DXW.CryptAlgorithmValues>();
    set => _Element.CryptographicAlgorithmType = EVU.SetEnumValue<DMW.CryptAlgorithmKind, DXW.CryptAlgorithmValues>(value);

  }

  /// <summary>
  /// Cryptographic Hashing Algorithm.
  /// </summary>
  [DataMember]
  public int? CryptographicAlgorithmSid
  {
    get => _Element.CryptographicAlgorithmSid?.Value;
    set
    {
      if (value != null)
        _Element.CryptographicAlgorithmSid = new DX.Int32Value { Value = (int)value };
      else
        _Element.CryptographicAlgorithmSid = null;
    }
  }

  /// <summary>
  /// Iterations to Run Hashing Algorithm.
  /// </summary>
  [DataMember]
  public uint? CryptographicSpinCount
  {
    get => _Element.CryptographicSpinCount?.Value;
    set
    {
      if (value != null)
        _Element.CryptographicSpinCount = new DX.UInt32Value { Value = (uint)value };
      else
        _Element.CryptographicSpinCount = null;
    }
  }

  /// <summary>
  /// Cryptographic Provider.
  /// </summary>
  [DataMember]
  public string? CryptographicProvider
  {
    get => _Element.CryptographicProvider?.Value;
    set
    {
      if (value != null)
        _Element.CryptographicProvider = new DX.StringValue { Value = (string)value };
      else
        _Element.CryptographicProvider = null;
    }
  }

  /// <summary>
  /// Cryptographic Algorithm Extensibility.
  /// </summary>
  [DataMember]
  public HexBinary? AlgorithmIdExtensibility
  {
    get
    {
      var val = _Element.AlgorithmIdExtensibility?.Value;
      if (val == null) return null;
      return new HexBinary(val);
    }
    set
    {
      if (value != null)
        _Element.AlgorithmIdExtensibility = new DX.HexBinaryValue { Value = value.ToString() };
      else
        _Element.AlgorithmIdExtensibility = null;
    }
  }

  /// <summary>
  /// Algorithm Extensibility Source.
  /// </summary>
  [DataMember]
  public string? AlgorithmIdExtensibilitySource
  {
    get => _Element.AlgorithmIdExtensibilitySource?.Value;
    set
    {
      if (value != null)
        _Element.AlgorithmIdExtensibilitySource = new DX.StringValue { Value = (string)value };
      else
        _Element.AlgorithmIdExtensibilitySource = null;
    }
  }

  /// <summary>
  /// Cryptographic Provider Type Extensibility.
  /// </summary>
  [DataMember]
  public HexBinary? CryptographicProviderTypeExtensibility
  {
    get
    {
      var val = _Element.CryptographicProviderTypeExtensibility?.Value;
      if (val == null) return null;
      return new HexBinary(val);
    }
    set
    {
      if (value != null)
        _Element.CryptographicProviderTypeExtensibility = new DX.HexBinaryValue { Value = value.ToString() };
      else
        _Element.CryptographicProviderTypeExtensibility = null;
    }
  }

  /// <summary>
  /// Provider Type Extensibility Source.
  /// </summary>
  [DataMember]
  public string? CryptographicProviderTypeExtSource
  {
    get => _Element.CryptographicProviderTypeExtSource?.Value;
    set
    {
      if (value != null)
        _Element.CryptographicProviderTypeExtSource = new DX.StringValue { Value = (string)value };
      else
        _Element.CryptographicProviderTypeExtSource = null;
    }
  }

  /// <summary>
  /// Password Hash.
  /// </summary>
  [DataMember]
  public byte[]? Hash
  {
    get
    {
      var val = _Element.Hash?.Value;
      if (val == null) return null;
      return Convert.FromBase64String(val);
    }
    set
    {
      if (value != null)
        _Element.Hash = new DX.Base64BinaryValue { Value = Convert.ToBase64String((byte[])value) };
      else
        _Element.Hash = null;
    }
  }

  /// <summary>
  /// Salt for Password Verifier.
  /// </summary>
  [DataMember]
  public byte[]? Salt
  {
    get
    {
      var val = _Element.Salt?.Value;
      if (val == null) return null;
      return Convert.FromBase64String(val);
    }
    set
    {
      if (value != null)
        _Element.Salt = new DX.Base64BinaryValue { Value = Convert.ToBase64String((byte[])value) };
      else
        _Element.Salt = null;
    }
  }

  /// <summary>
  /// AlgorithmName, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public string? AlgorithmName
  {
    get => _Element.AlgorithmName?.Value;
    set
    {
      if (value != null)
        _Element.AlgorithmName = new DX.StringValue { Value = (string)value };
      else
        _Element.AlgorithmName = null;
    }
  }

  /// <summary>
  /// HashValue, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public byte[]? HashValue
  {
    get
    {
      var val = _Element.HashValue?.Value;
      if (val == null) return null;
      return Convert.FromBase64String(val);
    }
    set
    {
      if (value != null)
        _Element.HashValue = new DX.Base64BinaryValue { Value = Convert.ToBase64String((byte[])value) };
      else
        _Element.HashValue = null;
    }
  }

  /// <summary>
  /// SaltValue, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public byte[]? SaltValue
  {
    get
    {
      var val = _Element.HashValue?.Value;
      if (val == null) return null;
      return Convert.FromBase64String(val);
    }
    set
    {
      if (value != null)
        _Element.SaltValue = new DX.Base64BinaryValue { Value = Convert.ToBase64String((byte[])value) };
      else
        _Element.SaltValue = null;
    }
  }

  /// <summary>
  /// SpinCount, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public int? SpinCount
  {
    get => _Element.SpinCount?.Value;
    set
    {
      if (value != null)
        _Element.SpinCount = new DX.Int32Value { Value = (Int32)value };
      else
        _Element.SpinCount = null;
    }
  }

}

