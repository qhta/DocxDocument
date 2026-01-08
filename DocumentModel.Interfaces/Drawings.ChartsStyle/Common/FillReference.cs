namespace DocumentModel.Drawings.ChartsStyle;

/// <summary>
///    FillReference in ChartsStyle extends FillReference in Drawings with StyleColor.
/// </summary>
public interface FillReference: DocumentModel.Drawings.FillReference
{
  public StyleColor? StyleColor { get; set; }
}