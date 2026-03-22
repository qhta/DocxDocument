namespace DocumentModel.VariantTypes;
#pragma warning disable CS1591
public partial class VTVStreamData
{
  public bool ShouldSerializeVersion() => Version is not null;
}
