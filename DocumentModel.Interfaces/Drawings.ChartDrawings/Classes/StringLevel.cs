namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the StringLevel Class.
/// </summary>
public interface StringLevel: IModelElement
{
  /// <summary>
  ///   ptCount
  /// </summary>
  public UInt32? PtCount { get; set; }
  /// <summary>
  ///   name
  /// </summary>
  public string? Name { get; set; }
  public Collection<ChartStringValue>? ChartStringValues { get; set; }
}