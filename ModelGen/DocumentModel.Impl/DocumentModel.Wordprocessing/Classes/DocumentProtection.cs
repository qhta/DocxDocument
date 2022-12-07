namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Editing Restrictions.
/// </summary>
public class DocumentProtectionImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.DocumentProtection>, DocumentProtection
{
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
  /// Cryptographic Algorithm Extensibility
  /// </summary>
  public String? AlgorithmIdExtensibility
  {
    get;
    set;
  }
  
  /// <summary>
  /// Cryptographic Provider Type Extensibility
  /// </summary>
  public String? CryptographicProviderTypeExtensibility
  {
    get;
    set;
  }
  
  /// <summary>
  /// Password Hash
  /// </summary>
  public String? Hash
  {
    get;
    set;
  }
  
  /// <summary>
  /// Salt for Password Verifier
  /// </summary>
  public String? Salt
  {
    get;
    set;
  }
  
  /// <summary>
  /// hashValue, this property is only available in Office 2010 and later.
  /// </summary>
  public String? HashValue
  {
    get;
    set;
  }
  
  /// <summary>
  /// saltValue, this property is only available in Office 2010 and later.
  /// </summary>
  public String? SaltValue
  {
    get;
    set;
  }
  
}
