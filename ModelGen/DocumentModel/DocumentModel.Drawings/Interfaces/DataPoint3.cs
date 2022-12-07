namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DataPoint Class.
/// </summary>
public interface DataPoint3
{
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public ShapeProperties2? ShapeProperties { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList2? ExtensionList { get ; set; }
  
}
