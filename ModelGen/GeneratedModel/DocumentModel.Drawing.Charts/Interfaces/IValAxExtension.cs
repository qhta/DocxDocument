namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the ValAxExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.INumberingFormat))]
public interface IValAxExtension // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri { get ; set; }
  
}
