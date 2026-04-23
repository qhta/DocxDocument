namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class Style
{
  public bool ShouldSerializeNameLocal() => !String.IsNullOrEmpty(NameLocal);
  public bool ShouldSerializeType() => Type is not null && ShouldSerialize(Type);
  public bool ShouldSerializeBaseStyle() => BaseStyle is not null && ShouldSerialize(BaseStyle);
  public bool ShouldSerializeNextParagraphStyle() => NextParagraphStyle is not null && ShouldSerialize(NextParagraphStyle);
  public bool ShouldSerializeAutomaticallyUpdate() => AutomaticallyUpdate is not null;
  public bool ShouldSerializeHidden() => Hidden is not null;
}
