namespace DocumentModel.Drawings;

public partial class SharpenSoften
{
  public bool ShouldSerializeAmount() => Amount is not null;
}
