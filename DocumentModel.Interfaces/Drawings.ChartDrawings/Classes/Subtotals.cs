namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the Subtotals Class.
/// </summary>
public interface Subtotals: IModelElement
{
  public Collection<UInt32>? UnsignedIntegerTypes { get; set; }
}