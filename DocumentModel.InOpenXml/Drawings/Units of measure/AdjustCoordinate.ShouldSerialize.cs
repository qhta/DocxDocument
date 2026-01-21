namespace DocumentModel.Drawings;

public partial class AdjustCoordinate
{
  public bool ShouldSerializeValue() => Value is not null;
}
