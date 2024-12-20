namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the DataLabelFieldTableEntry Class.
/// </summary>
public class DataLabelFieldTableEntry: ModelElement
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