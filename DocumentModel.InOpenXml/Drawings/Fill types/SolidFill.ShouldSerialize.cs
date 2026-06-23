namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class SolidFill
{
  public bool ShouldSerializeColor() => Color is not null;
}
