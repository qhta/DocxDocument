namespace DocumentModel.Wordprocessing;

/// <summary>
/// Suggested Filtering for List of Document Styles.
/// </summary>
public interface IStylePaneFormatFilter // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// val
  /// </summary>
  public DocumentModel.IHexBinaryValue? Val { get ; set; }
  
  /// <summary>
  /// allStyles, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? AllStyles { get ; set; }
  
  /// <summary>
  /// customStyles, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? CustomStyles { get ; set; }
  
  /// <summary>
  /// latentStyles, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? LatentStyles { get ; set; }
  
  /// <summary>
  /// stylesInUse, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? StylesInUse { get ; set; }
  
  /// <summary>
  /// headingStyles, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? HeadingStyles { get ; set; }
  
  /// <summary>
  /// numberingStyles, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? NumberingStyles { get ; set; }
  
  /// <summary>
  /// tableStyles, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? TableStyles { get ; set; }
  
  /// <summary>
  /// directFormattingOnRuns, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? DirectFormattingOnRuns { get ; set; }
  
  /// <summary>
  /// directFormattingOnParagraphs, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? DirectFormattingOnParagraphs { get ; set; }
  
  /// <summary>
  /// directFormattingOnNumbering, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? DirectFormattingOnNumbering { get ; set; }
  
  /// <summary>
  /// directFormattingOnTables, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? DirectFormattingOnTables { get ; set; }
  
  /// <summary>
  /// clearFormatting, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? ClearFormatting { get ; set; }
  
  /// <summary>
  /// top3HeadingStyles, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? Top3HeadingStyles { get ; set; }
  
  /// <summary>
  /// visibleStyles, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? VisibleStyles { get ; set; }
  
  /// <summary>
  /// alternateStyleNames, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? AlternateStyleNames { get ; set; }
  
}
