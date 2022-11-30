namespace DocumentModel.Drawing;

/// <summary>
/// Defines the PtExtension Class.
/// </summary>
public interface IPtExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Office2010.Drawing.Diagram.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
}
