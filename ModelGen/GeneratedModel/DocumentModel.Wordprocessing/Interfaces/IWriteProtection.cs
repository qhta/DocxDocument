namespace DocumentModel.Wordprocessing;

public interface IWriteProtection // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public bool? Recommended { get ; set; }
  
  public DocumentModel.Wordprocessing.CryptProvider? CryptographicProviderType { get ; set; }
  
  public DocumentModel.Wordprocessing.CryptAlgorithmClass? CryptographicAlgorithmClass { get ; set; }
  
  public DocumentModel.Wordprocessing.CryptAlgorithm? CryptographicAlgorithmType { get ; set; }
  
  public int? CryptographicAlgorithmSid { get ; set; }
  
  public uint? CryptographicSpinCount { get ; set; }
  
  public string? CryptographicProvider { get ; set; }
  
  public IHexBinaryValue? AlgorithmIdExtensibility { get ; set; }
  
  public string? AlgorithmIdExtensibilitySource { get ; set; }
  
  public IHexBinaryValue? CryptographicProviderTypeExtensibility { get ; set; }
  
  public string? CryptographicProviderTypeExtSource { get ; set; }
  
  public IBase64BinaryValue? Hash { get ; set; }
  
  public IBase64BinaryValue? Salt { get ; set; }
  
  public string? AlgorithmName { get ; set; }
  
  public IBase64BinaryValue? HashValue { get ; set; }
  
  public IBase64BinaryValue? SaltValue { get ; set; }
  
  public int? SpinCount { get ; set; }
  
}
