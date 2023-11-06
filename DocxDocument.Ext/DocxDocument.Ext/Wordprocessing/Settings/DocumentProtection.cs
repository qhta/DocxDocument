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
public partial class DocumentProtection: IOpenXmlElementMappedObject
{
  public DocumentProtection()
  {
    _Element = new DXW.DocumentProtection();
  }

  public DocumentProtection(DX.OpenXmlElement openXmlElement)
  {
    _Element = (DXW.DocumentProtection)openXmlElement;
  }

  public OpenXmlElementType GetElement<OpenXmlElementType>() where OpenXmlElementType: DX.OpenXmlElement
  {
    if (_Element is OpenXmlElementType validTypeElement)
    return validTypeElement;
      throw new ArgumentException($"Only {_Element.GetType()} type supported in GetElement of {this.GetType()}");
  }

  public DocumentProtection(DXW.DocumentProtection openXmlElement)
  {
    _Element = openXmlElement;
  }

  internal DXW.DocumentProtection _Element { get; private set; }

  public DMW.DocumentProtectionKind? Edit
  {
    get => _Element.Edit?.GetEnumValue<DMW.DocumentProtectionKind, DXW.DocumentProtectionValues>();
    set => _Element.Edit = EnumValueUtils.SetEnumValue<DMW.DocumentProtectionKind, DXW.DocumentProtectionValues>(value);
  }

  public bool? Formatting
  {
    get => _Element.Formatting?.Value;
    set
    {
      if (value != null)
        _Element.Formatting = new DX.OnOffValue { Value = (bool)value };
      else
        _Element.Formatting = null;
    }
  }

  public bool? Enforcement
  {
    get => _Element.Enforcement?.Value;
    set
    {
      if (value != null)
        _Element.Enforcement = new DX.OnOffValue { Value = (bool)value };
      else
        _Element.Enforcement = null;
    }
  }

  public DMW.CryptProviderKind? CryptographicProviderType
  {
    get => _Element.CryptographicProviderType?.GetEnumValue<DMW.CryptProviderKind, DXW.CryptProviderValues>();
    set => _Element.CryptographicProviderType = EnumValueUtils.SetEnumValue<DMW.CryptProviderKind, DXW.CryptProviderValues>(value);
  }

  public DMW.CryptAlgorithmClassKind? CryptographicAlgorithmClass
  {
    get => _Element.CryptographicAlgorithmClass?.GetEnumValue<DMW.CryptAlgorithmClassKind, DXW.CryptAlgorithmClassValues>();
    set => _Element.CryptographicAlgorithmClass = EnumValueUtils.SetEnumValue<DMW.CryptAlgorithmClassKind, DXW.CryptAlgorithmClassValues>(value);
  }

  public DMW.CryptAlgorithmKind? CryptographicAlgorithmType
  {
    get => _Element.CryptographicAlgorithmType?.GetEnumValue<DMW.CryptAlgorithmKind, DXW.CryptAlgorithmValues>();
    set => _Element.CryptographicAlgorithmType = EnumValueUtils.SetEnumValue<DMW.CryptAlgorithmKind, DXW.CryptAlgorithmValues>(value);
  }

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

