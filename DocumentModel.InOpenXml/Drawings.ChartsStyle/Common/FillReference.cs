namespace DocumentModel.Drawings.ChartsStyle;

/// <summary>
///    FillReference in ChartsStyle extends FillReference in Drawings with StyleColor.
/// </summary>
public class FillReference : DocumentModel.Drawings.FillReference
{
  public StyleColor? StyleColor { get; set; }
}