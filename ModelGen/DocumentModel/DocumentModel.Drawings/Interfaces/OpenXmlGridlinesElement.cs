namespace DocumentModel.Drawings;

/// <summary>
/// Defines the OpenXmlGridlinesElement Class.
/// </summary>
public interface OpenXmlGridlinesElement
{
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public ShapeProperties6? ShapeProperties { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList2? ExtensionList { get ; set; }
  
}
