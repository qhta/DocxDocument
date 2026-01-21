namespace DocumentModel.Wordprocessing;

public partial class CellMerge
{
  public bool ShouldSerializeVerticalMerge() => VerticalMerge is not null;
  public bool ShouldSerializeVerticalMergeOriginal() => VerticalMergeOriginal is not null;
}
