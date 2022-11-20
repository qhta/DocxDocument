namespace DocumentModel.Vml.Office;

/// <summary>
/// Shape Grouping History.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Vml.Office.IEntry))]
public interface IRegroupTable // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorValues? Extension { get ; set; }
  
}
