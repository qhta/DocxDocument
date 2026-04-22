namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class CellMerge
{
  public bool ShouldSerializeVerticalMerge() => VerticalMerge is not null;
  public bool ShouldSerializeVerticalMergeOriginal() => VerticalMergeOriginal is not null;
}
