namespace DocumentModel.Drawings.ChartsStyle;

#pragma warning disable CS1591

public partial class FontReference
{
  public bool ShouldSerializeStyleColor() => StyleColor is not null;
}
