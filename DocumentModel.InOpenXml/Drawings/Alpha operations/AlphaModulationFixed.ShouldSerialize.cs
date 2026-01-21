namespace DocumentModel.Drawings;

public partial class AlphaModulationFixed
{
  public bool ShouldSerializeAmount() => Amount is not null;
}
