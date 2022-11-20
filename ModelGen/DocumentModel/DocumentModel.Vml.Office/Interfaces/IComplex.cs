namespace DocumentModel.Vml.Office;

/// <summary>
/// Complex.
/// </summary>
public interface IComplex // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorValues? Extension { get ; set; }
  
}
