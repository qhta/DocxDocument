namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class Field
{
  public bool ShouldSerializeId() => Id is not null;
  public bool ShouldSerializeType() => Type is not null;
  public bool ShouldSerializeRunProperties() => RunProperties is not null;
  public bool ShouldSerializeParagraphProperties() => ParagraphProperties is not null;
  public bool ShouldSerializeText() => Text is not null;
}
