namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the DataBar Class.
/// </summary>
public interface IDataBar // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// minLength, this property is only available in Office 2010 and later.
  /// </summary>
  public UInt32? MinLength { get ; set; }
  
  /// <summary>
  /// maxLength, this property is only available in Office 2010 and later.
  /// </summary>
  public UInt32? MaxLength { get ; set; }
  
  /// <summary>
  /// showValue, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? ShowValue { get ; set; }
  
  /// <summary>
  /// border, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? Border { get ; set; }
  
  /// <summary>
  /// gradient, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? Gradient { get ; set; }
  
  /// <summary>
  /// direction, this property is only available in Office 2010 and later.
  /// </summary>
  public DataBarDirectionKind? Direction { get ; set; }
  
  /// <summary>
  /// negativeBarColorSameAsPositive, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? NegativeBarColorSameAsPositive { get ; set; }
  
  /// <summary>
  /// negativeBarBorderColorSameAsPositive, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? NegativeBarBorderColorSameAsPositive { get ; set; }
  
  /// <summary>
  /// axisPosition, this property is only available in Office 2010 and later.
  /// </summary>
  public DataBarAxisPositionKind? AxisPosition { get ; set; }
  
  public Collection<IConditionalFormattingValueObject>? ConditionalFormattingValueObjects { get ; set; }
  
  public IColorType? FillColor { get ; set; }
  
  public IColorType? BorderColor { get ; set; }
  
  public IColorType? NegativeFillColor { get ; set; }
  
  public IColorType? NegativeBorderColor { get ; set; }
  
  public IColorType? BarAxisColor { get ; set; }
  
}
