namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the DataBar Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IFillColor))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IBorderColor))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.INegativeFillColor))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.INegativeBorderColor))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IBarAxisColor))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IConditionalFormattingValueObject))]
public class DataBar: IDataBar
{
  /// <summary>
  /// minLength, this property is only available in Office 2010 and later.
  /// </summary>
  public uint? MinLength
  {
    get;
    set;
  }
  
  /// <summary>
  /// maxLength, this property is only available in Office 2010 and later.
  /// </summary>
  public uint? MaxLength
  {
    get;
    set;
  }
  
  /// <summary>
  /// showValue, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? ShowValue
  {
    get;
    set;
  }
  
  /// <summary>
  /// border, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Border
  {
    get;
    set;
  }
  
  /// <summary>
  /// gradient, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Gradient
  {
    get;
    set;
  }
  
  /// <summary>
  /// direction, this property is only available in Office 2010 and later.
  /// </summary>
  public DataBarDirectionValues? Direction
  {
    get;
    set;
  }
  
  /// <summary>
  /// negativeBarColorSameAsPositive, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? NegativeBarColorSameAsPositive
  {
    get;
    set;
  }
  
  /// <summary>
  /// negativeBarBorderColorSameAsPositive, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? NegativeBarBorderColorSameAsPositive
  {
    get;
    set;
  }
  
  /// <summary>
  /// axisPosition, this property is only available in Office 2010 and later.
  /// </summary>
  public DataBarAxisPositionValues? AxisPosition
  {
    get;
    set;
  }
  
}
