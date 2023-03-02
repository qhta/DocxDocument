namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the MinorGridlinesGridlines Class.
/// </summary>
public record MinorGridlinesGridlines
{
  public ShapeProperties? ShapeProperties { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}