namespace DocumentModel.Wordprocessing;

/// <summary>
/// This class specifies the set of document protection restrictions which have been applied to the contents of a WordprocessingML document. 
/// These restrictions should be enforced by applications editing this document when the enforcement attribute is turned on, 
/// and ignored (but persisted) otherwise. 
/// Document protection is a set of restrictions used to prevent unintentional changes to all or part of a WordprocessingML document. 
/// <para>
/// [Note: This protection does not encrypt the document, and malicious applications might circumvent its use. 
/// This protection is not intended as a security feature. end note]
/// </para>
/// </summary>
[DataContract]
public partial class DocumentProtection: ModelElement<DXW.DocumentProtection>
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public DocumentProtection(): base(){ }

  public DocumentProtection(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }

  public DocumentProtection(DXW.DocumentProtection openXmlElement): base(openXmlElement) { }
//#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

  /// <summary>
  /// Specifies the set of editing restrictions which shall be enforced on a given WordprocessingML document.
  /// </summary>
  public DMW.DocumentProtectionKind? Edit
  {
    get => _Element?.Edit?.GetEnumValue<DMW.DocumentProtectionKind, DXW.DocumentProtectionValues>();
    set => EnumValueUtils.SetEnumValue<DMW.DocumentProtectionKind, DXW.DocumentProtectionValues>(_ExistingElement, nameof(Edit), value);
  }

  /// <summary>
  /// Specifies if formatting restrictions are in effect for a given WordprocessingML document.
  /// This enables the document to restrict the types of styles that can exist in a given WordprocessingML document. 
  /// Specifically, by setting this attribute's value equal to true, every style whose locked element has a value of true 
  /// (or latent styles whose locked attribute is true) shall not be available for use in the application, 
  /// nor should any direct formatting. Only styles with a locked value of false can be used.
  /// </summary>
  [DataMember]
  public bool? Formatting
  {
    get => _Element?.Formatting?.Value;
    set
    {
      if (value != null)
        _ExistingElement.Formatting = new DX.OnOffValue { Value = (bool)value };
      else
        _ExistingElement.Formatting = null;
    }
  }

  [DataMember]
  public bool? Enforcement
  {
    get => _Element?.Enforcement?.Value;
    set
    {
      if (value != null)
        _ExistingElement.Enforcement = new DX.OnOffValue { Value = (bool)value };
      else
        _ExistingElement.Enforcement = null;
    }
  }

  [DataMember]
  public DMW.CryptProviderKind? CryptographicProviderType
  {
    get => _Element?.CryptographicProviderType?.GetEnumValue<DMW.CryptProviderKind, DXW.CryptProviderValues>();
    set => EnumValueUtils.SetEnumValue<DMW.CryptProviderKind, DXW.CryptProviderValues>(_ExistingElement, nameof(CryptographicProviderType), value);
  }

  [DataMember]
  public DMW.CryptAlgorithmClassKind? CryptographicAlgorithmClass
  {
    get => _Element?.CryptographicAlgorithmClass?.GetEnumValue<DMW.CryptAlgorithmClassKind, DXW.CryptAlgorithmClassValues>();
    set => EnumValueUtils.SetEnumValue<DMW.CryptAlgorithmClassKind, DXW.CryptAlgorithmClassValues>(_ExistingElement, nameof(CryptographicAlgorithmClass), value);
  }

  [DataMember]
  public DMW.CryptAlgorithmKind? CryptographicAlgorithmType
  {
    get => _Element?.CryptographicAlgorithmType?.GetEnumValue<DMW.CryptAlgorithmKind, DXW.CryptAlgorithmValues>();
    set => EnumValueUtils.SetEnumValue<DMW.CryptAlgorithmKind, DXW.CryptAlgorithmValues>(_ExistingElement, nameof(CryptographicAlgorithmType), value);
  }

  [DataMember]
  public int? CryptographicAlgorithmSid
  {
    get => _Element?.CryptographicAlgorithmSid?.Value;
    set
    {
      if (value != null)
        _ExistingElement.CryptographicAlgorithmSid = new DX.Int32Value { Value = (int)value };
      else
        _ExistingElement.CryptographicAlgorithmSid = null;
    }
  }

  [DataMember]
  public uint? CryptographicSpinCount
  {
    get => _Element?.CryptographicSpinCount?.Value;
    set
    {
      if (value != null)
        _ExistingElement.CryptographicSpinCount = new DX.UInt32Value { Value = (uint)value };
      else
        _ExistingElement.CryptographicSpinCount = null;
    }
  }


  /// <summary>
  /// The Microsoft Base Cryptographic Provider is the initial cryptographic service provider (CSP) provider, 
  /// and is distributed with CryptoAPI versions 1.0 and 2.0. 
  /// It is a general-purpose provider that supports digital signatures and data encryption.
  /// <para>
  /// The RSA public key algorithm is used for all public key operations.
  /// </para>
  /// </summary>
  [DataMember]
  public string? CryptographicProvider
  {
    get => _Element?.CryptographicProvider?.Value;
    set
    {
      if (value != null)
        _ExistingElement.CryptographicProvider = new DX.StringValue { Value = (string)value };
      else
        _ExistingElement.CryptographicProvider = null;
    }
  }

  [DataMember]
  public HexBinary? AlgorithmIdExtensibility
  {
    get
    {
      var val = _Element?.AlgorithmIdExtensibility?.Value;
      if (val == null) return null;
      return new HexBinary(val);
    }
    set
    {
      if (value != null)
        _ExistingElement.AlgorithmIdExtensibility = new DX.HexBinaryValue { Value = value.ToString() };
      else
        _ExistingElement.AlgorithmIdExtensibility = null;
    }
  }

  [DataMember]
  public string? AlgorithmIdExtensibilitySource
  {
    get => _Element?.AlgorithmIdExtensibilitySource?.Value;
    set
    {
      if (value != null)
        _ExistingElement.AlgorithmIdExtensibilitySource = new DX.StringValue { Value = (string)value };
      else
        _ExistingElement.AlgorithmIdExtensibilitySource = null;
    }
  }

  [DataMember]
  public HexBinary? CryptographicProviderTypeExtensibility
  {
    get 
    {
      var val = _Element?.CryptographicProviderTypeExtensibility?.Value;
      if (val == null) return null;
      return new HexBinary(val);
    }
    set
    {
      if (value != null)
        _ExistingElement.CryptographicProviderTypeExtensibility = new DX.HexBinaryValue { Value = value.ToString() };
      else
        _ExistingElement.CryptographicProviderTypeExtensibility = null;
    }
  }

  [DataMember]
  public string? CryptographicProviderTypeExtSource
  {
    get => _Element?.CryptographicProviderTypeExtSource?.Value;
    set
    {
      if (value != null)
        _ExistingElement.CryptographicProviderTypeExtSource = new DX.StringValue { Value = (string)value };
      else
        _ExistingElement.CryptographicProviderTypeExtSource = null;
    }
  }

  [DataMember]
  public byte[]? Hash
  {
    get
    {
      var val = _Element?.Hash?.Value;
      if (val == null) return null;
      return Convert.FromBase64String(val);
    }
    set
    {
      if (value != null)
        _ExistingElement.Hash = new DX.Base64BinaryValue { Value = Convert.ToBase64String((byte[])value) };
      else
        _ExistingElement.Hash = null;
    }
  }


  [DataMember]
  public byte[]? Salt
  {
    get
    {
      var val = _Element?.Salt?.Value;
      if (val == null) return null;
      return Convert.FromBase64String(val);
    }
    set
    {
      if (value != null)
        _ExistingElement.Salt = new DX.Base64BinaryValue { Value = Convert.ToBase64String((byte[])value) };
      else
        _ExistingElement.Salt = null;
    }
  }

  /// <summary>
  /// The name of the cryptographic hashing algorithm used to generate the hash value. Only those algorithms that are installed in the operating system’s cryptographic subsystem can be utilized by Office.
  /// The following hash algorithm names are reserved:
  /// MD2, MD4, MD5, RIPEMD-128, RIPEMD-160, SHA-1, SHA-256, SHA-384, SHA-512, WHIRLPOOL, 
  /// </summary>
  [DataMember]
  public string? AlgorithmName
  {
    get => _Element?.AlgorithmName?.Value;
    set
    {
      if (value != null)
        _ExistingElement.AlgorithmName = new DX.StringValue { Value = (string)value };
      else
        _ExistingElement.AlgorithmName = null;
    }
  }

  /// <summary>
  /// Specifies the hash value for the password required to edit this worksheet. 
  /// This value shall be compared with the resulting hash value after hashing the user-supplied password 
  /// using the algorithm specified by the preceding attributes and parent XML element. 
  /// If the two values match, the protection shall no longer be enforced.
  /// </summary>

  [DataMember]
  public byte[]? HashValue
  {
    get
    {
      var val = _Element?.HashValue?.Value;
      if (val == null) return null;
      return Convert.FromBase64String(val);
    }
    set
    {
      if (value != null)
        _ExistingElement.HashValue = new DX.Base64BinaryValue { Value = Convert.ToBase64String((byte[])value) };
      else
        _ExistingElement.HashValue = null;
    }
  }

  /// <summary>
  /// Specifies the random bytes that are pre-pended to the user-supplied password before it was hashed by the hashing algorithm.
  /// </summary>
  [DataMember]
  public byte[]? SaltValue
  {
    get
    {
      var val = _Element?.HashValue?.Value;
      if (val == null) return null;
      return Convert.FromBase64String(val);
    }
    set
    {
      if (value != null)
        _ExistingElement.SaltValue = new DX.Base64BinaryValue { Value = Convert.ToBase64String((byte[])value) };
      else
        _ExistingElement.SaltValue = null;
    }
  }

  /// <summary>
  /// Specifies the number of times the hashing function shall be iteratively run (using each iteration's result as the input for the next iteration).
  /// </summary>
  [DataMember]
  public int? SpinCount
  {
    get => _Element?.SpinCount?.Value;
    set
    {
      if (value != null)
        _ExistingElement.SpinCount = new DX.Int32Value { Value = (Int32)value };
      else
        _ExistingElement.SpinCount = null;
    }
  }

}

