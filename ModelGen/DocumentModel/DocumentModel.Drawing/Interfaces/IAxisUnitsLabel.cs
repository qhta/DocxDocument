namespace DocumentModel.Drawing;

/// <summary>
/// Defines the AxisUnitsLabel Class.
/// </summary>
public interface IAxisUnitsLabel // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Text.
  /// </summary>
  public DocumentModel.Drawing.IText? Text { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Drawing.IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// TxPrTextBody.
  /// </summary>
  public DocumentModel.Drawing.ITxPrTextBody? TxPrTextBody { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
