namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a reference to multi-level string data for a chart axis or series.
/// </summary>
public interface MultiLevelStringReference
{
  /// <summary>
  ///   Formula used to reference the multi-level string data.
  /// </summary>
  public string? Formula { get; set; }

  /// <summary>
  ///   Cache containing the multi-level string values.
  /// </summary>
  public MultiLevelStringCache? MultiLevelStringCache { get; set; }

  /// <summary>
  ///   Collection of extension elements for additional reference properties.
  /// </summary>
  public MultiLvlStrRefExtensionList? MultiLvlStrRefExtensionList { get; set; }
}