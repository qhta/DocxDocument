namespace DocumentModel.Drawings;

/// <summary>
/// Defines the OpenXmlGridlinesElement Class.
/// </summary>
public interface OpenXmlGridlinesElement // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public ShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get ; set; }
  
}
