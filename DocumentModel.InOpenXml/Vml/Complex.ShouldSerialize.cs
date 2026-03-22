namespace DocumentModel.Vml;
#pragma warning disable CS1591
public partial class Complex
{
  public bool ShouldSerializeExtension() => Extension is not null;
}
