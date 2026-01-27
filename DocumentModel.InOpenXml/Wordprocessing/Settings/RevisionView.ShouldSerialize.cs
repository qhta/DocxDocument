namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class RevisionView
{
  public bool ShouldSerializeMarkup() => Markup is not null;
  public bool ShouldSerializeComments() => Comments is not null;
  public bool ShouldSerializeDisplayRevision() => DisplayRevision is not null;
  public bool ShouldSerializeFormatting() => Formatting is not null;
  public bool ShouldSerializeInkAnnotations() => InkAnnotations is not null;
}
