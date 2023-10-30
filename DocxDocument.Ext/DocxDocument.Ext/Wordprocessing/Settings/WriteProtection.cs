using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Specifies the write protection settings which have been applied to a WordprocessingML document. 
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
public partial class WriteProtection
{
  public WriteProtection(DXW.WriteProtection openXmlElement)
  {
    _Element = openXmlElement;
  }

  internal DXW.WriteProtection _Element { get; private set; }

  public Boolean? Recommended
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

  public DXW.CryptProviderValues? CryptographicProviderType
  {
    get => _Element.CryptographicProviderType?.Value;
    set
    {
      if (value != null)
        _Element.CryptographicProviderType = new DX.EnumValue<DXW.CryptProviderValues> { Value = (DXW.CryptProviderValues)value };
      else
        _Element.CryptographicProviderType = null;
    }
  }

  public DXW.CryptAlgorithmClassValues? CryptographicAlgorithmClass
  {
    get => _Element.CryptographicAlgorithmClass?.Value;
    set
    {
      if (value != null)
        _Element.CryptographicAlgorithmClass = new DX.EnumValue<DXW.CryptAlgorithmClassValues> { Value = (DXW.CryptAlgorithmClassValues)value };
      else
        _Element.CryptographicAlgorithmClass = null;
    }
  }

  public DXW.CryptAlgorithmValues? CryptographicAlgorithmType
  {
    get => _Element.CryptographicAlgorithmType?.Value;
    set
    {
      if (value != null)
        _Element.CryptographicAlgorithmType = new DX.EnumValue<DXW.CryptAlgorithmValues> { Value = (DXW.CryptAlgorithmValues)value };
      else
        _Element.CryptographicAlgorithmType = null;
    }
  }

  public Int32? CryptographicAlgorithmSid
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

  public UInt32? CryptographicSpinCount
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

  public String? CryptographicProvider
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

  public String? AlgorithmIdExtensibilitySource
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

  public String? CryptographicProviderTypeExtSource
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

  public String? AlgorithmName
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

  public Int32? SpinCount
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

