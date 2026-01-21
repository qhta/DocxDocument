namespace DocumentModel.Drawings;

public partial class PositiveSize2DType
{
  public bool ShouldSerializeCx() => Cx is not null;
  public bool ShouldSerializeCy() => Cy is not null;
}
