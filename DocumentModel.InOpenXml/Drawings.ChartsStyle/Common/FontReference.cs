namespace DocumentModel.Drawings.ChartsStyle;

/// <summary>
///    FontReference in ChartsStyle extends FontReference in Drawings with StyleColor.
/// </summary>
public class FontReference : DocumentModel.Drawings.FontReference
{
  public StyleColor? StyleColor { get; set; }
}