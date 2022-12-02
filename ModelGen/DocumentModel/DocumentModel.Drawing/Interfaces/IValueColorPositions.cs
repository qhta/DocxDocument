namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ValueColorPositions Class.
/// </summary>
public interface IValueColorPositions // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// count, this property is only available in Office 2016 and later.
  /// </summary>
  public Int32? Count { get ; set; }
  
  /// <summary>
  /// MinValueColorEndPosition.
  /// </summary>
  public IMinValueColorEndPosition? MinValueColorEndPosition { get ; set; }
  
  /// <summary>
  /// ValueColorMiddlePosition.
  /// </summary>
  public IValueColorMiddlePosition? ValueColorMiddlePosition { get ; set; }
  
  /// <summary>
  /// MaxValueColorEndPosition.
  /// </summary>
  public IMaxValueColorEndPosition? MaxValueColorEndPosition { get ; set; }
  
}
