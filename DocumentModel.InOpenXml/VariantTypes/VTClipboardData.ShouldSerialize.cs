namespace DocumentModel.VariantTypes;
#pragma warning disable CS1591
public partial class VTClipboardData
{
  public bool ShouldSerializeFormat() => Format is not null;
  public bool ShouldSerializeSize() => Size is not null;
}
