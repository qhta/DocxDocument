namespace DocumentModel.Vml.Office;

/// <summary>
/// Most Recently Used Colors.
/// </summary>
public interface IColorMostRecentlyUsed // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension { get ; set; }
  
  /// <summary>
  /// Recent colors
  /// </summary>
  public System.String? Colors { get ; set; }
  
}
