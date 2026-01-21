namespace DocumentModel.VariantTypes;

public partial class VTClipboardData
{
  public bool ShouldSerializeFormat() => Format is not null;
  public bool ShouldSerializeSize() => Size is not null;
}
