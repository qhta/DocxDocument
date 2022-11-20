namespace DocumentModel.Vml.Office;

/// <summary>
/// Most Recently Used Colors.
/// </summary>
public interface IColorMostRecentlyUsed // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorValues? Extension { get ; set; }
  
  /// <summary>
  /// Recent colors
  /// </summary>
  public string? Colors { get ; set; }
  
}
