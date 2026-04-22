namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class NonVisualInkContentPartProperties
{
  public bool ShouldSerializeIsComment() => IsComment is not null;
  public bool ShouldSerializeContentPartLocks() => ContentPartLocks is not null;
  public bool ShouldSerializeOfficeArtExtensionList() => OfficeArtExtensionList is not null;
}
