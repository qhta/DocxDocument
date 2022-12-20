namespace DocumentModel.Wordprocessing;

/// <summary>
/// Write Protection.
/// </summary>
public partial class WriteProtectionImpl: ModelElementImpl, WriteProtection
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.WriteProtection? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.WriteProtection?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public WriteProtectionImpl(): base() {}
  
  public WriteProtectionImpl(DocumentFormat.OpenXml.Wordprocessing.WriteProtection openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Recommend Write Protection in User Interface
  /// </summary>
  public Boolean? Recommended
  {
    get => (System.Boolean?)OpenXmlElement?.Recommended?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Recommended = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Cryptographic Provider Type
  /// </summary>
  public DocumentModel.Wordprocessing.CryptProviderKind? CryptographicProviderType
  {
    get => (DocumentModel.Wordprocessing.CryptProviderKind?)OpenXmlElement?.CryptographicProviderType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CryptographicProviderType = (DocumentFormat.OpenXml.Wordprocessing.CryptProviderValues?)value;
    }
  }
  
  /// <summary>
  /// Cryptographic Algorithm Class
  /// </summary>
  public DocumentModel.Wordprocessing.CryptAlgorithmClassKind? CryptographicAlgorithmClass
  {
    get => (DocumentModel.Wordprocessing.CryptAlgorithmClassKind?)OpenXmlElement?.CryptographicAlgorithmClass?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CryptographicAlgorithmClass = (DocumentFormat.OpenXml.Wordprocessing.CryptAlgorithmClassValues?)value;
    }
  }
  
  /// <summary>
  /// Cryptographic Algorithm Type
  /// </summary>
  public DocumentModel.Wordprocessing.CryptAlgorithmKind? CryptographicAlgorithmType
  {
    get => (DocumentModel.Wordprocessing.CryptAlgorithmKind?)OpenXmlElement?.CryptographicAlgorithmType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CryptographicAlgorithmType = (DocumentFormat.OpenXml.Wordprocessing.CryptAlgorithmValues?)value;
    }
  }
  
  /// <summary>
  /// Cryptographic Hashing Algorithm
  /// </summary>
  public Int32? CryptographicAlgorithmSid
  {
    get => (System.Int32?)OpenXmlElement?.CryptographicAlgorithmSid?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CryptographicAlgorithmSid = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Iterations to Run Hashing Algorithm
  /// </summary>
  public UInt32? CryptographicSpinCount
  {
    get => (System.UInt32?)OpenXmlElement?.CryptographicSpinCount?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CryptographicSpinCount = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// Cryptographic Provider
  /// </summary>
  public String? CryptographicProvider
  {
    get => (System.String?)OpenXmlElement?.CryptographicProvider?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CryptographicProvider = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Cryptographic Algorithm Extensibility
  /// </summary>
  public DocumentModel.HexBinary? AlgorithmIdExtensibility
  {
    get
    {
      if (OpenXmlElement?.AlgorithmIdExtensibility?.Value != null)
        return (DocumentModel.HexBinary)OpenXmlElement.AlgorithmIdExtensibility.Value;
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value != null)
          OpenXmlElement.AlgorithmIdExtensibility = new DocumentFormat.OpenXml.HexBinaryValue{ Value = value.ToString() };
        else
          OpenXmlElement.AlgorithmIdExtensibility = null;
      }
    }
  }
  
  /// <summary>
  /// Algorithm Extensibility Source
  /// </summary>
  public String? AlgorithmIdExtensibilitySource
  {
    get => (System.String?)OpenXmlElement?.AlgorithmIdExtensibilitySource?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AlgorithmIdExtensibilitySource = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Cryptographic Provider Type Extensibility
  /// </summary>
  public DocumentModel.HexBinary? CryptographicProviderTypeExtensibility
  {
    get
    {
      if (OpenXmlElement?.CryptographicProviderTypeExtensibility?.Value != null)
        return (DocumentModel.HexBinary)OpenXmlElement.CryptographicProviderTypeExtensibility.Value;
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value != null)
          OpenXmlElement.CryptographicProviderTypeExtensibility = new DocumentFormat.OpenXml.HexBinaryValue{ Value = value.ToString() };
        else
          OpenXmlElement.CryptographicProviderTypeExtensibility = null;
      }
    }
  }
  
  /// <summary>
  /// Provider Type Extensibility Source
  /// </summary>
  public String? CryptographicProviderTypeExtSource
  {
    get => (System.String?)OpenXmlElement?.CryptographicProviderTypeExtSource?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CryptographicProviderTypeExtSource = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Password Hash
  /// </summary>
  public DocumentModel.Base64Binary? Hash
  {
    get
    {
      if (OpenXmlElement?.Hash?.Value != null)
        return (DocumentModel.Base64Binary)OpenXmlElement.Hash.Value;
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value != null)
          OpenXmlElement.Hash = new DocumentFormat.OpenXml.Base64BinaryValue{ Value = value.ToString() };
        else
          OpenXmlElement.Hash = null;
      }
    }
  }
  
  /// <summary>
  /// Salt for Password Verifier
  /// </summary>
  public DocumentModel.Base64Binary? Salt
  {
    get
    {
      if (OpenXmlElement?.Salt?.Value != null)
        return (DocumentModel.Base64Binary)OpenXmlElement.Salt.Value;
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value != null)
          OpenXmlElement.Salt = new DocumentFormat.OpenXml.Base64BinaryValue{ Value = value.ToString() };
        else
          OpenXmlElement.Salt = null;
      }
    }
  }
  
  /// <summary>
  /// algorithmName, this property is only available in Office 2010 and later.
  /// </summary>
  public String? AlgorithmName
  {
    get => (System.String?)OpenXmlElement?.AlgorithmName?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AlgorithmName = (System.String?)value;
    }
  }
  
  /// <summary>
  /// hashValue, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Base64Binary? HashValue
  {
    get
    {
      if (OpenXmlElement?.HashValue?.Value != null)
        return (DocumentModel.Base64Binary)OpenXmlElement.HashValue.Value;
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value != null)
          OpenXmlElement.HashValue = new DocumentFormat.OpenXml.Base64BinaryValue{ Value = value.ToString() };
        else
          OpenXmlElement.HashValue = null;
      }
    }
  }
  
  /// <summary>
  /// saltValue, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Base64Binary? SaltValue
  {
    get
    {
      if (OpenXmlElement?.SaltValue?.Value != null)
        return (DocumentModel.Base64Binary)OpenXmlElement.SaltValue.Value;
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value != null)
          OpenXmlElement.SaltValue = new DocumentFormat.OpenXml.Base64BinaryValue{ Value = value.ToString() };
        else
          OpenXmlElement.SaltValue = null;
      }
    }
  }
  
  /// <summary>
  /// spinCount, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? SpinCount
  {
    get => (System.Int32?)OpenXmlElement?.SpinCount?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SpinCount = (System.Int32?)value;
    }
  }
  
}
