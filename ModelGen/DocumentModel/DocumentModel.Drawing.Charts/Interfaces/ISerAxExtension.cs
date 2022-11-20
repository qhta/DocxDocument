namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the SerAxExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.INumberingFormat))]
public interface ISerAxExtension // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri { get ; set; }
  
}
