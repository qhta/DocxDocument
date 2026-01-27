namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class PresetColor
{
  public bool ShouldSerializeVal() => Val is not null;
}
