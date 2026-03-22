namespace DocumentModel.Vml;
#pragma warning disable CS1591
public partial class FillExtendedProperties
{
  public bool ShouldSerializeExtension() => Extension is not null;
  public bool ShouldSerializeType() => Type is not null;
}
