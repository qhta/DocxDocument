namespace DocumentModel.Drawing;

/// <summary>
/// Defines the AxisTitle Class.
/// </summary>
public interface IAxisTitle // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Text.
  /// </summary>
  public IText? Text { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// TxPrTextBody.
  /// </summary>
  public ITxPrTextBody? TxPrTextBody { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
