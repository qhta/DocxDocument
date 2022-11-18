namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the StrRefExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IFormulaReference))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IFullReference))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.ILevelReference))]
public interface IStrRefExtension // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri { get ; set; }
  
}
