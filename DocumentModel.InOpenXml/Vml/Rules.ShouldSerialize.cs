namespace DocumentModel.Vml;

public partial class Rules
{
  public bool ShouldSerializeExtension() => Extension is not null;
}
