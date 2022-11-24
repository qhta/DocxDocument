namespace DocumentModel.Vml.Office;

/// <summary>
/// Most Recently Used Colors.
/// </summary>
public interface IColorMostRecentlyUsed // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorValues? Extension { get ; set; }
  
  /// <summary>
  /// Recent colors
  /// </summary>
  public String? Colors { get ; set; }
  
}
