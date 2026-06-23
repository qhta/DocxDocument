namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class ForegroundColor
{
  public bool ShouldSerializeColor() => Color is not null;
}
