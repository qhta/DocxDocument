namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class Break
{
  public bool ShouldSerializeRunProperties() => RunProperties is not null;
}
