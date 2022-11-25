namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ConditionalFormatStyle Class.
/// </summary>
public interface IConditionalFormatStyle // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Conditional Formatting Bit Mask
  /// </summary>
  public System.String? Val { get ; set; }
  
  /// <summary>
  /// firstRow, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? FirstRow { get ; set; }
  
  /// <summary>
  /// lastRow, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? LastRow { get ; set; }
  
  /// <summary>
  /// firstColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? FirstColumn { get ; set; }
  
  /// <summary>
  /// lastColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? LastColumn { get ; set; }
  
  /// <summary>
  /// oddVBand, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? OddVerticalBand { get ; set; }
  
  /// <summary>
  /// evenVBand, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? EvenVerticalBand { get ; set; }
  
  /// <summary>
  /// oddHBand, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? OddHorizontalBand { get ; set; }
  
  /// <summary>
  /// evenHBand, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? EvenHorizontalBand { get ; set; }
  
  /// <summary>
  /// firstRowFirstColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? FirstRowFirstColumn { get ; set; }
  
  /// <summary>
  /// firstRowLastColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? FirstRowLastColumn { get ; set; }
  
  /// <summary>
  /// lastRowFirstColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? LastRowFirstColumn { get ; set; }
  
  /// <summary>
  /// lastRowLastColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? LastRowLastColumn { get ; set; }
  
}
