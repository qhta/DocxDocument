namespace DocumentModel.Wordprocessing;

/// <summary>
/// Revision Information for Table Grid Column Definitions.
/// </summary>
public class TableGridChangeImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.TableGridChange>, TableGridChange
{
  /// <summary>
  /// Previous Table Grid.
  /// </summary>
  public PreviousTableGrid? PreviousTableGrid
  {
    get;
    set;
  }
  
}
