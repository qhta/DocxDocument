namespace DocumentModel.Vml.Office;

/// <summary>
/// Shape Fill Extended Properties.
/// </summary>
public interface IFillExtendedProperties // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorValues? Extension { get ; set; }
  
  /// <summary>
  /// Fill Type
  /// </summary>
  public FillValues? Type { get ; set; }
  
}
