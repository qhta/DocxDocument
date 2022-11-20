namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ConditionalFormatStyle Class.
/// </summary>
public class ConditionalFormatStyle: IConditionalFormatStyle
{
  /// <summary>
  /// Conditional Formatting Bit Mask
  /// </summary>
  public string? Val
  {
    get;
    set;
  }
  
  /// <summary>
  /// firstRow, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? FirstRow
  {
    get;
    set;
  }
  
  /// <summary>
  /// lastRow, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? LastRow
  {
    get;
    set;
  }
  
  /// <summary>
  /// firstColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? FirstColumn
  {
    get;
    set;
  }
  
  /// <summary>
  /// lastColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? LastColumn
  {
    get;
    set;
  }
  
  /// <summary>
  /// oddVBand, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? OddVerticalBand
  {
    get;
    set;
  }
  
  /// <summary>
  /// evenVBand, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? EvenVerticalBand
  {
    get;
    set;
  }
  
  /// <summary>
  /// oddHBand, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? OddHorizontalBand
  {
    get;
    set;
  }
  
  /// <summary>
  /// evenHBand, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? EvenHorizontalBand
  {
    get;
    set;
  }
  
  /// <summary>
  /// firstRowFirstColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? FirstRowFirstColumn
  {
    get;
    set;
  }
  
  /// <summary>
  /// firstRowLastColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? FirstRowLastColumn
  {
    get;
    set;
  }
  
  /// <summary>
  /// lastRowFirstColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? LastRowFirstColumn
  {
    get;
    set;
  }
  
  /// <summary>
  /// lastRowLastColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? LastRowLastColumn
  {
    get;
    set;
  }
  
}
