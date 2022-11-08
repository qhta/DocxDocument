namespace DocxDocument.Model;

[JsonConverter(typeof(StringEnumConverter))]
public enum ProofingState
{
  Dirty,
  Clean
}