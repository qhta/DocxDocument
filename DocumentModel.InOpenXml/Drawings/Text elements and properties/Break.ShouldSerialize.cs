namespace DocumentModel.Drawings;

public partial class Break
{
  public bool ShouldSerializeRunProperties() => RunProperties is not null;
}
