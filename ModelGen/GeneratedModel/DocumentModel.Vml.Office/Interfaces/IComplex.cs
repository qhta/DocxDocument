namespace DocumentModel.Vml.Office;

/// <summary>
/// Complex.
/// </summary>
public interface IComplex // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehavior? Extension { get ; set; }
  
}
