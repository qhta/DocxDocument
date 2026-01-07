namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the DataLabelFieldTableEntry Class.
/// </summary>
public interface DataLabelFieldTableEntry: CollectionItem
{
  /// <summary>
  ///   TextFieldGuid.
  /// </summary>
  public string? TextFieldGuid { get; set; }
  /// <summary>
  ///   Formula.
  /// </summary>
  public string? Formula { get; set; }
  /// <summary>
  ///   DataLabelFieldTableCache.
  /// </summary>
  public DataLabelFieldTableCache? DataLabelFieldTableCache { get; set; }
}