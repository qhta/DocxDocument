namespace DocumentModel.VariantTypes;

public partial class VTVStreamData
{
  public bool ShouldSerializeVersion() => Version is not null;
}
