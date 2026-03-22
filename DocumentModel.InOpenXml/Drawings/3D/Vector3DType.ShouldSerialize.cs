namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class Vector3DType
{
  public bool ShouldSerializeDx() => Dx is not null;
  public bool ShouldSerializeDy() => Dy is not null;
  public bool ShouldSerializeDz() => Dz is not null;
}
