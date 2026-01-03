namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the MinorGridlinesGridlines Class.
/// </summary>
public interface MinorGridlinesGridlines: IModelElement
{
  public ShapeProperties? ShapeProperties { get; set; }
  public ExtensionList? ExtensionList { get; set; }
}