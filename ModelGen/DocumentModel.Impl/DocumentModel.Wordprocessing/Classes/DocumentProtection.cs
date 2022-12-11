namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Editing Restrictions.
/// </summary>
public class DocumentProtectionImpl: ModelElementImpl, DocumentProtection
{
  public DocumentFormat.OpenXml.Wordprocessing.DocumentProtection? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.DocumentProtection?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DocumentProtectionImpl(): base() {}
  
  public DocumentProtectionImpl(DocumentFormat.OpenXml.Wordprocessing.DocumentProtection openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Document Editing Restrictions
  /// </summary>
  public DocumentProtectionKind? Edit
  {
    get => (DocumentProtectionKind?)OpenXmlElement?.Edit?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Edit = (DocumentFormat.OpenXml.Wordprocessing.DocumentProtectionValues?)value;
    }
  }
  
  /// <summary>
  /// Only Allow Formatting With Unlocked Styles
  /// </summary>
  public Boolean? Formatting
  {
    get => (Boolean?)OpenXmlElement?.Formatting?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Formatting = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Enforce Document Protection Settings
  /// </summary>
  public Boolean? Enforcement
  {
    get => (Boolean?)OpenXmlElement?.Enforcement?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Enforcement = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Cryptographic Provider Type
  /// </summary>
  public CryptProviderKind? CryptographicProviderType
  {
    get => (CryptProviderKind?)OpenXmlElement?.CryptographicProviderType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CryptographicProviderType = (DocumentFormat.OpenXml.Wordprocessing.CryptProviderValues?)value;
    }
  }
  
  /// <summary>
  /// Cryptographic Algorithm Class
  /// </summary>
  public CryptAlgorithmClassKind? CryptographicAlgorithmClass
  {
    get => (CryptAlgorithmClassKind?)OpenXmlElement?.CryptographicAlgorithmClass?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CryptographicAlgorithmClass = (DocumentFormat.OpenXml.Wordprocessing.CryptAlgorithmClassValues?)value;
    }
  }
  
  /// <summary>
  /// Cryptographic Algorithm Type
  /// </summary>
  public CryptAlgorithmKind? CryptographicAlgorithmType
  {
    get => (CryptAlgorithmKind?)OpenXmlElement?.CryptographicAlgorithmType?.Value;
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
    get => (Int32?)OpenXmlElement?.CryptographicAlgorithmSid?.Value;
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
    get => (UInt32?)OpenXmlElement?.CryptographicSpinCount?.Value;
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
    get => (String?)OpenXmlElement?.CryptographicProvider?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CryptographicProvider = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Cryptographic Algorithm Extensibility
  /// </summary>
  public HexBinaryValue? AlgorithmIdExtensibility
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Algorithm Extensibility Source
  /// </summary>
  public String? AlgorithmIdExtensibilitySource
  {
    get => (String?)OpenXmlElement?.AlgorithmIdExtensibilitySource?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AlgorithmIdExtensibilitySource = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Cryptographic Provider Type Extensibility
  /// </summary>
  public HexBinaryValue? CryptographicProviderTypeExtensibility
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Provider Type Extensibility Source
  /// </summary>
  public String? CryptographicProviderTypeExtSource
  {
    get => (String?)OpenXmlElement?.CryptographicProviderTypeExtSource?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CryptographicProviderTypeExtSource = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Password Hash
  /// </summary>
  public Base64BinaryValue? Hash
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Salt for Password Verifier
  /// </summary>
  public Base64BinaryValue? Salt
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// algorithmName, this property is only available in Office 2010 and later.
  /// </summary>
  public String? AlgorithmName
  {
    get => (String?)OpenXmlElement?.AlgorithmName?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AlgorithmName = (System.String?)value;
    }
  }
  
  /// <summary>
  /// hashValue, this property is only available in Office 2010 and later.
  /// </summary>
  public Base64BinaryValue? HashValue
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// saltValue, this property is only available in Office 2010 and later.
  /// </summary>
  public Base64BinaryValue? SaltValue
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// spinCount, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? SpinCount
  {
    get => (Int32?)OpenXmlElement?.SpinCount?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SpinCount = (System.Int32?)value;
    }
  }
  
}
