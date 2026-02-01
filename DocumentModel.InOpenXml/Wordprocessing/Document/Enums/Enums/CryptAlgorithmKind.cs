namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the CryptAlgorithmValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXP.CryptAlgorithmValues))]
public enum CryptAlgorithmKind
{
  /// <summary>
  ///   Any Type.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXP.CryptAlgorithmValues.TypeAny))]
  TypeAny,
  /// <summary>
  ///   custom.
  /// </summary>
  Custom
}