namespace DocxDocument.Model;

/// <summary>
/// Cryptographic Algorithm Type.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum CryptAlgorithmType
{
  AnyType,
  Custom
}