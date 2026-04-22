namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class AlphaModulationFixed
{
  public bool ShouldSerializeAmount() => Amount is not null;
}
