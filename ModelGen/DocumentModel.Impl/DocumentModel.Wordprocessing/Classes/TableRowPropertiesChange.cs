namespace DocumentModel.Wordprocessing;

/// <summary>
/// Revision Information for Table Row Properties.
/// </summary>
public class TableRowPropertiesChangeImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.TableRowPropertiesChange>, TableRowPropertiesChange
{
  /// <summary>
  /// Previous Table Row Properties.
  /// </summary>
  public PreviousTableRowProperties? PreviousTableRowProperties
  {
    get;
    set;
  }
  
}
