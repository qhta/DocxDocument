namespace DocumentModel.Wordprocessing;

public partial class Rsids
{
  public bool ShouldSerializeRsidRoot() => RsidRoot is not null;
}
