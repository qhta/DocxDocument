namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class StyleMatrixReferenceType
{
  public bool ShouldSerializeIndex() => Index is not null;
  public bool ShouldSerializeColor() => Color is not null;
}
