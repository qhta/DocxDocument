namespace DocumentModel.Spreadsheet;

/// <summary>
/// Data Consolidation.
/// </summary>
public interface IDataConsolidate // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Function Index
  /// </summary>
  public DataConsolidateFunctionKind? Function { get ; set; }
  
  /// <summary>
  /// Use Left Column Labels
  /// </summary>
  public Boolean? LeftLabels { get ; set; }
  
  /// <summary>
  /// startLabels, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? StartLabels { get ; set; }
  
  /// <summary>
  /// Labels In Top Row
  /// </summary>
  public Boolean? TopLabels { get ; set; }
  
  /// <summary>
  /// Link
  /// </summary>
  public Boolean? Link { get ; set; }
  
  /// <summary>
  /// Data Consolidation References.
  /// </summary>
  public IDataReferences? DataReferences { get ; set; }
  
}
