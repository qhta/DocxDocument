namespace DocumentModel;

/// <summary>
/// Specifies the set of document protection restrictions which have been applied to the contents of a WordprocessingML document. 
/// These restrictions should be enforced by applications editing this document when the enforcement attribute is turned on, 
/// and ignored (but persisted) otherwise. 
/// Document protection is a set of restrictions used to prevent unintentional changes to all or part of a WordprocessingML document. 
/// [Note: This protection does not encrypt the document, and malicious applications might circumvent its use. 
/// This protection is not intended as a security feature. end note]
/// </summary>
public partial class DocumentProtection
{
  public DocumentProtection(DXW.DocumentProtection documentProtection)
  {
    _DocumentProtection = documentProtection;
  }

  internal DXW.DocumentProtection _DocumentProtection { get; private set; }

  public DXW.DocumentProtectionValues? Edit
  {
    get => _DocumentProtection.Edit?.Value;
    set
    {
      if (value != null)
        _DocumentProtection.Edit = new DX.EnumValue<DXW.DocumentProtectionValues> { Value = (DXW.DocumentProtectionValues)value };
      else
        _DocumentProtection.Edit = null;
    }
  }

  public Boolean? Formatting
  {
    get => _DocumentProtection.Formatting?.Value;
    set
    {
      if (value != null)
        _DocumentProtection.Formatting = new DX.OnOffValue { Value = (bool)value };
      else
        _DocumentProtection.Formatting = null;
    }
  }

  public Boolean? Enforcement
  {
    get => _DocumentProtection.Enforcement?.Value;
    set
    {
      if (value != null)
        _DocumentProtection.Enforcement = new DX.OnOffValue { Value = (bool)value };
      else
        _DocumentProtection.Enforcement = null;
    }
  }

  public DXW.CryptProviderValues? CryptographicProviderType
  {
    get => _DocumentProtection.CryptographicProviderType?.Value;
    set
    {
      if (value != null)
        _DocumentProtection.CryptographicProviderType = new DX.EnumValue<DXW.CryptProviderValues> { Value = (DXW.CryptProviderValues)value };
      else
        _DocumentProtection.CryptographicProviderType = null;
    }
  }

  public DXW.CryptAlgorithmClassValues? CryptographicAlgorithmClass
  {
    get => _DocumentProtection.CryptographicAlgorithmClass?.Value;
    set
    {
      if (value != null)
        _DocumentProtection.CryptographicAlgorithmClass = new DX.EnumValue<DXW.CryptAlgorithmClassValues> { Value = (DXW.CryptAlgorithmClassValues)value };
      else
        _DocumentProtection.CryptographicAlgorithmClass = null;
    }
  }

  public DXW.CryptAlgorithmValues? CryptographicAlgorithmType
  {
    get => _DocumentProtection.CryptographicAlgorithmType?.Value;
    set
    {
      if (value != null)
        _DocumentProtection.CryptographicAlgorithmType = new DX.EnumValue<DXW.CryptAlgorithmValues> { Value = (DXW.CryptAlgorithmValues)value };
      else
        _DocumentProtection.CryptographicAlgorithmType = null;
    }
  }

  public Int32? CryptographicAlgorithmSid
  {
    get => _DocumentProtection.CryptographicAlgorithmSid?.Value;
    set
    {
      if (value != null)
        _DocumentProtection.CryptographicAlgorithmSid = new DX.Int32Value { Value = (int)value };
      else
        _DocumentProtection.CryptographicAlgorithmSid = null;
    }
  }

  public UInt32? CryptographicSpinCount
  {
    get => _DocumentProtection.CryptographicSpinCount?.Value;
    set
    {
      if (value != null)
        _DocumentProtection.CryptographicSpinCount = new DX.UInt32Value { Value = (uint)value };
      else
        _DocumentProtection.CryptographicSpinCount = null;
    }
  }

  public String? CryptographicProvider
  {
    get => _DocumentProtection.CryptographicProvider?.Value;
    set
    {
      if (value != null)
        _DocumentProtection.CryptographicProvider = new DX.StringValue { Value = (string)value };
      else
        _DocumentProtection.CryptographicProvider = null;
    }
  }

  public byte[]? AlgorithmIdExtensibility
  {
    get
    {
      var val = _DocumentProtection.AlgorithmIdExtensibility?.Value;
      if (val == null) return null;
      return Convert.FromHexString(val);
    }
    set
    {
      if (value != null)
        _DocumentProtection.AlgorithmIdExtensibility = new DX.HexBinaryValue { Value = Convert.ToHexString((byte[])value) };
      else
        _DocumentProtection.AlgorithmIdExtensibility = null;
    }
  }

  public String? AlgorithmIdExtensibilitySource
  {
    get => _DocumentProtection.AlgorithmIdExtensibilitySource?.Value;
    set
    {
      if (value != null)
        _DocumentProtection.AlgorithmIdExtensibilitySource = new DX.StringValue { Value = (string)value };
      else
        _DocumentProtection.AlgorithmIdExtensibilitySource = null;
    }
  }

  public byte[]? CryptographicProviderTypeExtensibility
  {
    get 
    {
      var val = _DocumentProtection.CryptographicProviderTypeExtensibility?.Value;
      if (val == null) return null;
      return Convert.FromHexString(val);
    }
    set
    {
      if (value != null)
        _DocumentProtection.CryptographicProviderTypeExtensibility = new DX.HexBinaryValue { Value = Convert.ToHexString((byte[])value) };
      else
        _DocumentProtection.CryptographicProviderTypeExtensibility = null;
    }
  }

  public String? CryptographicProviderTypeExtSource
  {
    get => _DocumentProtection.CryptographicProviderTypeExtSource?.Value;
    set
    {
      if (value != null)
        _DocumentProtection.CryptographicProviderTypeExtSource = new DX.StringValue { Value = (string)value };
      else
        _DocumentProtection.CryptographicProviderTypeExtSource = null;
    }
  }

  public byte[]? Hash
  {
    get
    {
      var val = _DocumentProtection.Hash?.Value;
      if (val == null) return null;
      return Convert.FromBase64String(val);
    }
    set
    {
      if (value != null)
        _DocumentProtection.Hash = new DX.Base64BinaryValue { Value = Convert.ToBase64String((byte[])value) };
      else
        _DocumentProtection.Hash = null;
    }
  }

  public byte[]? Salt
  {
    get
    {
      var val = _DocumentProtection.Salt?.Value;
      if (val == null) return null;
      return Convert.FromBase64String(val);
    }
    set
    {
      if (value != null)
        _DocumentProtection.Salt = new DX.Base64BinaryValue { Value = Convert.ToBase64String((byte[])value) };
      else
        _DocumentProtection.Salt = null;
    }
  }

  public String? AlgorithmName
  {
    get => _DocumentProtection.AlgorithmName?.Value;
    set
    {
      if (value != null)
        _DocumentProtection.AlgorithmName = new DX.StringValue { Value = (string)value };
      else
        _DocumentProtection.AlgorithmName = null;
    }
  }

  public byte[]? HashValue
  {
    get
    {
      var val = _DocumentProtection.HashValue?.Value;
      if (val == null) return null;
      return Convert.FromBase64String(val);
    }
    set
    {
      if (value != null)
        _DocumentProtection.HashValue = new DX.Base64BinaryValue { Value = Convert.ToBase64String((byte[])value) };
      else
        _DocumentProtection.HashValue = null;
    }
  }

  public byte[]? SaltValue
  {
    get
    {
      var val = _DocumentProtection.HashValue?.Value;
      if (val == null) return null;
      return Convert.FromBase64String(val);
    }
    set
    {
      if (value != null)
        _DocumentProtection.SaltValue = new DX.Base64BinaryValue { Value = Convert.ToBase64String((byte[])value) };
      else
        _DocumentProtection.SaltValue = null;
    }
  }

  public Int32? SpinCount
  {
    get => _DocumentProtection.SpinCount?.Value;
    set
    {
      if (value != null)
        _DocumentProtection.SpinCount = new DX.Int32Value { Value = (Int32)value };
      else
        _DocumentProtection.SpinCount = null;
    }
  }

}

