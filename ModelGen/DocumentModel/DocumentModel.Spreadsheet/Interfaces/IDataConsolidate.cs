namespace DocumentModel.Spreadsheet;

/// <summary>
/// Data Consolidation.
/// </summary>
public interface IDataConsolidate // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Function Index
  /// </summary>
  public DocumentModel.Spreadsheet.DataConsolidateFunctionKind? Function { get ; set; }
  
  /// <summary>
  /// Use Left Column Labels
  /// </summary>
  public System.Boolean? LeftLabels { get ; set; }
  
  /// <summary>
  /// startLabels, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? StartLabels { get ; set; }
  
  /// <summary>
  /// Labels In Top Row
  /// </summary>
  public System.Boolean? TopLabels { get ; set; }
  
  /// <summary>
  /// Link
  /// </summary>
  public System.Boolean? Link { get ; set; }
  
  /// <summary>
  /// Data Consolidation References.
  /// </summary>
  public DocumentModel.Spreadsheet.IDataReferences? DataReferences { get ; set; }
  
}
