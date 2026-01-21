namespace DocumentModel.Vml;

public partial class Complex
{
  public bool ShouldSerializeExtension() => Extension is not null;
}
