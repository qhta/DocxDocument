namespace DocumentModel.Drawings;

public partial class Extent
{
  public bool ShouldSerializeCx() => Cx is not null;
  public bool ShouldSerializeCy() => Cy is not null;
}
