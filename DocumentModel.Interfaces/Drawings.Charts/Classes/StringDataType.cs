namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the StringDataType Class.
/// </summary>
public interface StringDataType: IModelElement
{
  /// <summary>
  ///   PointCount.
  /// </summary>
  public UInt32? PointCount { get; set; }
}