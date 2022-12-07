namespace DocumentModel.Drawings;

/// <summary>
/// Defines the FormatOverride Class.
/// </summary>
public interface FormatOverride
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
