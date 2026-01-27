namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class Style
{
  public bool ShouldSerializeNameLocal() => NameLocal is not null;
  public bool ShouldSerializeBuiltIn() => BuiltIn is not null;
  public bool ShouldSerializeType() => Type is not null;
  public bool ShouldSerializeBaseStyle() => BaseStyle is not null;
  public bool ShouldSerializeNextParagraphStyle() => NextParagraphStyle is not null;
  public bool ShouldSerializeAutomaticallyUpdate() => AutomaticallyUpdate is not null;
  public bool ShouldSerializeHidden() => Hidden is not null;
}
