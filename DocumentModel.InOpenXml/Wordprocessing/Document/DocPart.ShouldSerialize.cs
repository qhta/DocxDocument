namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class DocPart
{
  public bool ShouldSerializeDocPartProperties() => DocPartProperties is not null;
  public bool ShouldSerializeDocPartBody() => DocPartBody is not null;
}
