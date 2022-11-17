namespace DocumentModel.Presentation;

public interface IModificationVerifier // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public DocumentModel.Presentation.CryptProvider? CryptographicProviderType { get ; set; }

  public DocumentModel.Presentation.CryptAlgorithmClass? CryptographicAlgorithmClass { get ; set; }

  public DocumentModel.Presentation.CryptAlgorithm? CryptographicAlgorithmType { get ; set; }

  public uint? CryptographicAlgorithmSid { get ; set; }

  public uint? SpinCount { get ; set; }

  public IBase64BinaryValue? SaltData { get ; set; }

  public string? HashData { get ; set; }

  public string? CryptographicProvider { get ; set; }

  public uint? ExtendedCryptographicAlgorithm { get ; set; }

  public string? ExtendedCryptographicAlgorithmSource { get ; set; }

  public uint? CryptographicProviderTypeExtensibility { get ; set; }

  public string? CryptographicProviderTypeExtensibilitySource { get ; set; }

  public string? AlgorithmName { get ; set; }

  public IBase64BinaryValue? HashValue { get ; set; }

  public IBase64BinaryValue? SaltValue { get ; set; }

  public uint? SpinValue { get ; set; }

}
