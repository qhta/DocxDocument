namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of conditional table style formatting properties which have been applied to this paragraph, if this paragraph is contained within a table cell.
/// </summary>
public partial class ConditionalFormatStyle
{
  
  /// <summary>
  ///   Conditional Formatting Bit Mask
  /// </summary>
  public String? Val { get; set; }
  
  
  /// <summary>
  ///   firstRow, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? FirstRow { get; set; }
  
  
  /// <summary>
  ///   lastRow, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? LastRow { get; set; }
  
  
  /// <summary>
  ///   firstColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? FirstColumn { get; set; }
  
  
  /// <summary>
  ///   lastColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? LastColumn { get; set; }
  
  
  /// <summary>
  ///   oddVBand, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? OddVerticalBand { get; set; }
  
  
  /// <summary>
  ///   evenVBand, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? EvenVerticalBand { get; set; }
  
  
  /// <summary>
  ///   oddHBand, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? OddHorizontalBand { get; set; }
  
  
  /// <summary>
  ///   evenHBand, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? EvenHorizontalBand { get; set; }
  
  
  /// <summary>
  ///   firstRowFirstColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? FirstRowFirstColumn { get; set; }
  
  
  /// <summary>
  ///   firstRowLastColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? FirstRowLastColumn { get; set; }
  
  
  /// <summary>
  ///   lastRowFirstColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? LastRowFirstColumn { get; set; }
  
  
  /// <summary>
  ///   lastRowLastColumn, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? LastRowLastColumn { get; set; }
  
}
