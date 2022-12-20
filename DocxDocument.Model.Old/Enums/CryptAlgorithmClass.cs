namespace DocxDocument.Model;

[JsonConverter(typeof(StringEnumConverter))]
public enum CryptAlgorithmClass
{
  Hash,
  Custom,
}