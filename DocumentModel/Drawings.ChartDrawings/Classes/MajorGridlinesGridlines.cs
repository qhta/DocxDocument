namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the MajorGridlinesGridlines Class.
/// </summary>
public record MajorGridlinesGridlines
{
  public ShapeProperties? ShapeProperties { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}