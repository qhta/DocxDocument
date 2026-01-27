namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class WriteProtection
{
  public bool ShouldSerializeRecommended() => Recommended is not null;
  public bool ShouldSerializeCryptographicProviderType() => CryptographicProviderType is not null;
  public bool ShouldSerializeCryptographicAlgorithmClass() => CryptographicAlgorithmClass is not null;
  public bool ShouldSerializeCryptographicAlgorithmType() => CryptographicAlgorithmType is not null;
  public bool ShouldSerializeCryptographicAlgorithmSid() => CryptographicAlgorithmSid is not null;
  public bool ShouldSerializeCryptographicSpinCount() => CryptographicSpinCount is not null;
  public bool ShouldSerializeCryptographicProvider() => CryptographicProvider is not null;
  public bool ShouldSerializeAlgorithmIdExtensibility() => AlgorithmIdExtensibility is not null;
  public bool ShouldSerializeAlgorithmIdExtensibilitySource() => AlgorithmIdExtensibilitySource is not null;
  public bool ShouldSerializeCryptographicProviderTypeExtensibility() => CryptographicProviderTypeExtensibility is not null;
  public bool ShouldSerializeCryptographicProviderTypeExtSource() => CryptographicProviderTypeExtSource is not null;
  public bool ShouldSerializeHash() => Hash is not null;
  public bool ShouldSerializeSalt() => Salt is not null;
  public bool ShouldSerializeAlgorithmName() => AlgorithmName is not null;
  public bool ShouldSerializeHashValue() => HashValue is not null;
  public bool ShouldSerializeSaltValue() => SaltValue is not null;
  public bool ShouldSerializeSpinCount() => SpinCount is not null;
}
