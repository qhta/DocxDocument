namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the MajorGridlinesGridlines Class.
/// </summary>
public interface MajorGridlinesGridlines: IModelElement
{
  public ShapeProperties? ShapeProperties { get; set; }
  public ExtensionList? ExtensionList { get; set; }
}