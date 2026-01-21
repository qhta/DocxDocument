namespace DocumentModel.Drawings;

public partial class PredecessorDrawingElementReference
{
  public bool ShouldSerializePredecessor() => Predecessor is not null;
}
