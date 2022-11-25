namespace DocumentModel.Vml.Office;

/// <summary>
/// Shape Fill Extended Properties.
/// </summary>
public interface IFillExtendedProperties // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension { get ; set; }
  
  /// <summary>
  /// Fill Type
  /// </summary>
  public DocumentModel.Vml.Office.FillKind? Type { get ; set; }
  
}
