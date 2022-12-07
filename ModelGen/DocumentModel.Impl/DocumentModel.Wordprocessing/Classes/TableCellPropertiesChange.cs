namespace DocumentModel.Wordprocessing;

/// <summary>
/// Revision Information for Table Cell Properties.
/// </summary>
public class TableCellPropertiesChangeImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.TableCellPropertiesChange>, TableCellPropertiesChange
{
  /// <summary>
  /// Previous Table Cell Properties.
  /// </summary>
  public PreviousTableCellProperties? PreviousTableCellProperties
  {
    get;
    set;
  }
  
}
