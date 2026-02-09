namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the CryptAlgorithmClassValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXP.CryptAlgorithmClassValues))]
public enum CryptAlgorithmClass
{
  /// <summary>
  ///   Hashing.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXP.CryptAlgorithmClassValues.Hash))]
  Hash,
  /// <summary>
  ///   custom.
  /// </summary>
  Custom
}