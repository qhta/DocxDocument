namespace DocumentModel.Drawings;

/// <summary>
/// Defines the FormatOverride Class.
/// </summary>
public interface FormatOverride
{
  /// <summary>
  /// idx, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? Idx { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public ShapeProperties6? ShapeProperties { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList2? ExtensionList { get ; set; }
  
}
