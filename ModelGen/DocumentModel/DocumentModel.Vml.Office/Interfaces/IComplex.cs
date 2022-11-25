namespace DocumentModel.Vml.Office;

/// <summary>
/// Complex.
/// </summary>
public interface IComplex // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension { get ; set; }
  
}
