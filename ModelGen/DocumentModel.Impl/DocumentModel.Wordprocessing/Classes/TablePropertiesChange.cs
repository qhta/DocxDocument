namespace DocumentModel.Wordprocessing;

/// <summary>
/// Revision Information for Table Properties.
/// </summary>
public class TablePropertiesChangeImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.TablePropertiesChange>, TablePropertiesChange
{
  /// <summary>
  /// Previous Table Properties.
  /// </summary>
  public PreviousTableProperties? PreviousTableProperties
  {
    get;
    set;
  }
  
}
