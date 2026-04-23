namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class WriteProtection
{
  public bool ShouldSerializeRecommended() => Recommended is not null;
  public bool ShouldSerializeCryptographicProviderType() => CryptographicProviderType is not null && ShouldSerialize(CryptographicProviderType);
  public bool ShouldSerializeCryptographicAlgorithmClass() => CryptographicAlgorithmClass is not null && ShouldSerialize(CryptographicAlgorithmClass);
  public bool ShouldSerializeCryptographicAlgorithmType() => CryptographicAlgorithmType is not null && ShouldSerialize(CryptographicAlgorithmType);
  public bool ShouldSerializeCryptographicAlgorithmSid() => CryptographicAlgorithmSid is not null && ShouldSerialize(CryptographicAlgorithmSid);
  public bool ShouldSerializeCryptographicSpinCount() => CryptographicSpinCount is not null && ShouldSerialize(CryptographicSpinCount);
  public bool ShouldSerializeCryptographicProvider() => !String.IsNullOrEmpty(CryptographicProvider);
  public bool ShouldSerializeAlgorithmIdExtensibility() => AlgorithmIdExtensibility is not null && ShouldSerialize(AlgorithmIdExtensibility);
  public bool ShouldSerializeAlgorithmIdExtensibilitySource() => !String.IsNullOrEmpty(AlgorithmIdExtensibilitySource);
  public bool ShouldSerializeCryptographicProviderTypeExtensibility() => CryptographicProviderTypeExtensibility is not null && ShouldSerialize(CryptographicProviderTypeExtensibility);
  public bool ShouldSerializeCryptographicProviderTypeExtSource() => !String.IsNullOrEmpty(CryptographicProviderTypeExtSource);
  public bool ShouldSerializeHash() => Hash is not null && ShouldSerialize(Hash);
  public bool ShouldSerializeSalt() => Salt is not null && ShouldSerialize(Salt);
  public bool ShouldSerializeAlgorithmName() => !String.IsNullOrEmpty(AlgorithmName);
  public bool ShouldSerializeHashValue() => HashValue is not null && ShouldSerialize(HashValue);
  public bool ShouldSerializeSaltValue() => SaltValue is not null && ShouldSerialize(SaltValue);
  public bool ShouldSerializeSpinCount() => SpinCount is not null && ShouldSerialize(SpinCount);
}
