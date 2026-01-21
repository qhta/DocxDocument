namespace DocumentModel.Drawings;

public partial class Miter
{
  public bool ShouldSerializeLimit() => Limit is not null;
}
