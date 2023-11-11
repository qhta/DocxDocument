namespace DocumentModel.Wordprocessing;

/// <summary>
/// This class specifies the set of document protection restrictions which have been applied to the contents of a WordprocessingML document. 
/// These restrictions should be enforced by applications editing this document when the enforcement attribute is turned on, 
/// and ignored (but persisted) otherwise. 
/// Document protection is a set of restrictions used to prevent unintentional changes to all or part of a WordprocessingML document. 
/// [Note: This protection does not encrypt the document, and malicious applications might circumvent its use. 
/// This protection is not intended as a security feature. end note]
/// </summary>
[DataContract]
public partial class DocumentProtection: ModelElement<DXW.DocumentProtection>
{
  public DocumentProtection(): base(){ }

  public DocumentProtection(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }

  public DocumentProtection(DXW.DocumentProtection openXmlElement): base(openXmlElement) { }

  public DMW.DocumentProtectionKind? Edit
  {
    get => _Element?.Edit?.GetEnumValue<DMW.DocumentProtectionKind, DXW.DocumentProtectionValues>();
    set => _ExistingElement.Edit = EnumValueUtils.SetEnumValue<DMW.DocumentProtectionKind, DXW.DocumentProtectionValues>(value);
  }

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

  public DMW.CryptProviderKind? CryptographicProviderType
  {
    get => _Element?.CryptographicProviderType?.GetEnumValue<DMW.CryptProviderKind, DXW.CryptProviderValues>();
    set => _ExistingElement.CryptographicProviderType = EnumValueUtils.SetEnumValue<DMW.CryptProviderKind, DXW.CryptProviderValues>(value);
  }

  public DMW.CryptAlgorithmClassKind? CryptographicAlgorithmClass
  {
    get => _Element?.CryptographicAlgorithmClass?.GetEnumValue<DMW.CryptAlgorithmClassKind, DXW.CryptAlgorithmClassValues>();
    set => _ExistingElement.CryptographicAlgorithmClass = EnumValueUtils.SetEnumValue<DMW.CryptAlgorithmClassKind, DXW.CryptAlgorithmClassValues>(value);
  }

  public DMW.CryptAlgorithmKind? CryptographicAlgorithmType
  {
    get => _Element?.CryptographicAlgorithmType?.GetEnumValue<DMW.CryptAlgorithmKind, DXW.CryptAlgorithmValues>();
    set => _ExistingElement.CryptographicAlgorithmType = EnumValueUtils.SetEnumValue<DMW.CryptAlgorithmKind, DXW.CryptAlgorithmValues>(value);
  }

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

