namespace DocumentModel.Vml.Office;

/// <summary>
/// Rule Set.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Vml.Office.IRule))]
public interface IRules // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorValues? Extension { get ; set; }
  
}
