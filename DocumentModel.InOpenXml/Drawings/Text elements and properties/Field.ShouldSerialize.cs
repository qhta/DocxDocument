namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class Field
{
  public bool ShouldSerializeId() => !String.IsNullOrEmpty(Id);
  public bool ShouldSerializeType() => !String.IsNullOrEmpty(Type);
  public bool ShouldSerializeRunProperties() => RunProperties is not null;
  public bool ShouldSerializeParagraphProperties() => ParagraphProperties is not null;
  public bool ShouldSerializeText() => !String.IsNullOrEmpty(Text);
}
