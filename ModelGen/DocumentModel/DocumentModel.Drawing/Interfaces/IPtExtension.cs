namespace DocumentModel.Drawing;

/// <summary>
/// Defines the PtExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.Diagram.INonVisualDrawingProperties))]
public interface IPtExtension // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri { get ; set; }
  
}
