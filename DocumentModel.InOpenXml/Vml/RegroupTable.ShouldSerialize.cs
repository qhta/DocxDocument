namespace DocumentModel.Vml;

public partial class RegroupTable
{
  public bool ShouldSerializeExtension() => Extension is not null;
  public bool ShouldSerializeEntries() => Entries is not null;
}
