namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the DataBar Class.
/// </summary>
public interface IDataBar // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// minLength, this property is only available in Office 2010 and later.
  /// </summary>
  public System.UInt32? MinLength { get ; set; }
  
  /// <summary>
  /// maxLength, this property is only available in Office 2010 and later.
  /// </summary>
  public System.UInt32? MaxLength { get ; set; }
  
  /// <summary>
  /// showValue, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? ShowValue { get ; set; }
  
  /// <summary>
  /// border, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? Border { get ; set; }
  
  /// <summary>
  /// gradient, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? Gradient { get ; set; }
  
  /// <summary>
  /// direction, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Spreadsheet.DataBarDirectionKind? Direction { get ; set; }
  
  /// <summary>
  /// negativeBarColorSameAsPositive, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? NegativeBarColorSameAsPositive { get ; set; }
  
  /// <summary>
  /// negativeBarBorderColorSameAsPositive, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? NegativeBarBorderColorSameAsPositive { get ; set; }
  
  /// <summary>
  /// axisPosition, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Spreadsheet.DataBarAxisPositionKind? AxisPosition { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IConditionalFormattingValueObject>? ConditionalFormattingValueObjects { get ; set; }
  
  public DocumentModel.Spreadsheet.IColorType? FillColor { get ; set; }
  
  public DocumentModel.Spreadsheet.IColorType? BorderColor { get ; set; }
  
  public DocumentModel.Spreadsheet.IColorType? NegativeFillColor { get ; set; }
  
  public DocumentModel.Spreadsheet.IColorType? NegativeBorderColor { get ; set; }
  
  public DocumentModel.Spreadsheet.IColorType? BarAxisColor { get ; set; }
  
}
