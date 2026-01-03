namespace DocumentModel.Drawings.ChartsStyle;

/// <summary>
///   Defines the MarkerLayoutProperties Class.
/// </summary>
public interface MarkerLayoutProperties: IModelElement
{
  /// <summary>
  ///   symbol
  /// </summary>
  public MarkerStyle? Symbol { get; set; }
  /// <summary>
  ///   size
  /// </summary>
  public Byte? Size { get; set; }
}