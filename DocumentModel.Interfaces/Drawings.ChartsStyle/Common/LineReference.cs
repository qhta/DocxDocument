namespace DocumentModel.Drawings.ChartsStyle;

/// <summary>
///    LineReference in ChartsStyle extends LineReference in Drawings with StyleColor.
/// </summary>
public interface LineReference: DocumentModel.Drawings.LineReference
{
  public StyleColor? StyleColor { get; set; }
}