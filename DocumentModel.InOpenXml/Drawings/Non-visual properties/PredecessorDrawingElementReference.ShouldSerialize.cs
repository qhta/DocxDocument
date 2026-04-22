namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class PredecessorDrawingElementReference
{
  public bool ShouldSerializePredecessor() => !String.IsNullOrEmpty(Predecessor);
}
