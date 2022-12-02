namespace DocumentModel.Vml;

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
