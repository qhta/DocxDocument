namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class FormulaReference
{
  public bool ShouldSerializeSequenceOfReferences() => !String.IsNullOrEmpty(SequenceOfReferences);
}
