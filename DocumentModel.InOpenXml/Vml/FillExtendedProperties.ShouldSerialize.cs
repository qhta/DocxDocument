namespace DocumentModel.Vml;

public partial class FillExtendedProperties
{
  public bool ShouldSerializeExtension() => Extension is not null;
  public bool ShouldSerializeType() => Type is not null;
}
