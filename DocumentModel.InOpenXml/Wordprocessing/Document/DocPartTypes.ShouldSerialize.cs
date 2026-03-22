namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class DocPartTypes
{
  public bool ShouldSerializeAll() => All is not null;
  public bool ShouldSerializeDocPartType() => DocPartType is not null;
}
