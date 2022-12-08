namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableWidthDxaNilType Class.
/// </summary>
public interface TableWidthDxaNilType
{
  /// <summary>
  /// w
  /// </summary>
  public Int16? Width { get ; set; }
  
  /// <summary>
  /// type
  /// </summary>
  public TableWidthKind? Type { get ; set; }
  
}
