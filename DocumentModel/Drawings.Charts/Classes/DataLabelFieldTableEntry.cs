namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the DataLabelFieldTableEntry Class.
/// </summary>
public class DataLabelFieldTableEntry
{
  /// <summary>
  ///   TextFieldGuid.
  /// </summary>
  public String? TextFieldGuid { get; set; }

  /// <summary>
  ///   Formula.
  /// </summary>
  public String? Formula { get; set; }

  /// <summary>
  ///   DataLabelFieldTableCache.
  /// </summary>
  public DataLabelFieldTableCache? DataLabelFieldTableCache { get; set; }
}