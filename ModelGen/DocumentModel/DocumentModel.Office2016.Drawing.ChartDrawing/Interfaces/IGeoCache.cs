namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the GeoCache Class.
/// </summary>
public interface IGeoCache // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// provider, this property is only available in Office 2016 and later.
  /// </summary>
  public System.String? Provider { get ; set; }
  
  public System.String? Xsdbase64Binary { get ; set; }
  
  public DocumentModel.Office2016.Drawing.ChartDrawing.IClear? Clear { get ; set; }
  
}
