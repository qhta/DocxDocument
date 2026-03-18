namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class NumRefExtension
{
  public bool ShouldSerializeFullReference() => FullReference is not null;
  public bool ShouldSerializeLevelReference() => LevelReference is not null;
  public bool ShouldSerializeFormulaReference() => FormulaReference is not null;
}
