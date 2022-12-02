namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ValueColorPositions Class.
/// </summary>
public interface IValueColorPositions // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// count, this property is only available in Office 2016 and later.
  /// </summary>
  public System.Int32? Count { get ; set; }
  
  /// <summary>
  /// MinValueColorEndPosition.
  /// </summary>
  public DocumentModel.Drawing.IMinValueColorEndPosition? MinValueColorEndPosition { get ; set; }
  
  /// <summary>
  /// ValueColorMiddlePosition.
  /// </summary>
  public DocumentModel.Drawing.IValueColorMiddlePosition? ValueColorMiddlePosition { get ; set; }
  
  /// <summary>
  /// MaxValueColorEndPosition.
  /// </summary>
  public DocumentModel.Drawing.IMaxValueColorEndPosition? MaxValueColorEndPosition { get ; set; }
  
}
