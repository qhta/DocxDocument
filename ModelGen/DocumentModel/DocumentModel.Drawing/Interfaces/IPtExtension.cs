namespace DocumentModel.Drawing;

/// <summary>
/// Defines the PtExtension Class.
/// </summary>
public interface IPtExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
}
