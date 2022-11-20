namespace DocumentModel.Spreadsheet;

/// <summary>
/// Data Consolidation.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IDataReferences))]
public class DataConsolidate: IDataConsolidate
{
  /// <summary>
  /// Function Index
  /// </summary>
  public DataConsolidateFunctionValues? Function
  {
    get;
    set;
  }
  
  /// <summary>
  /// Use Left Column Labels
  /// </summary>
  public bool? LeftLabels
  {
    get;
    set;
  }
  
  /// <summary>
  /// startLabels, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? StartLabels
  {
    get;
    set;
  }
  
  /// <summary>
  /// Labels In Top Row
  /// </summary>
  public bool? TopLabels
  {
    get;
    set;
  }
  
  /// <summary>
  /// Link
  /// </summary>
  public bool? Link
  {
    get;
    set;
  }
  
  /// <summary>
  /// Data Consolidation References.
  /// </summary>
  public IDataReferences? DataReferences
  {
    get;
    set;
  }
  
}
