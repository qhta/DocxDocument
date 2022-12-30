namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the DataLabelFieldTableEntry Class.
/// </summary>
public partial class DataLabelFieldTableEntry
{
  /// <summary>
  /// TextFieldGuid.
  /// </summary>
  public String? TextFieldGuid { get; set; }
  
  /// <summary>
  /// Formula.
  /// </summary>
  public String? Formula { get; set; }
  
  /// <summary>
  /// DataLabelFieldTableCache.
  /// </summary>
  public DocumentModel.Drawings.Charts.DataLabelFieldTableCache? DataLabelFieldTableCache { get; set; }
  
}
