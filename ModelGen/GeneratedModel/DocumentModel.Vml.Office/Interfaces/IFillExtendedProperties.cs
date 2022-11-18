namespace DocumentModel.Vml.Office;

/// <summary>
/// Shape Fill Extended Properties.
/// </summary>
public interface IFillExtendedProperties // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehavior? Extension { get ; set; }
  
  /// <summary>
  /// Fill Type
  /// </summary>
  public Fill? Type { get ; set; }
  
}
