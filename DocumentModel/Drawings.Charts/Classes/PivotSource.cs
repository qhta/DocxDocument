namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the PivotSource Class.
/// </summary>
public class PivotSource: ModelElement
{
  /// <summary>
  ///   Pivot Name.
  /// </summary>
  public String? PivotTableName { get; set; }

  /// <summary>
  ///   Format ID.
  /// </summary>
  public UInt32? FormatId { get; set; }

  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}