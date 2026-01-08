namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a reference to numeric values for a chart, including formula, numbering cache, and extension list.
/// </summary>
public interface NumberReference
{
  /// <summary>
  ///   Formula used to reference the numeric values.
  /// </summary>
  public string? Formula { get; set; }

  /// <summary>
  ///   Numbering cache containing the referenced numeric values.
  /// </summary>
  public NumberingCache? NumberingCache { get; set; }

  /// <summary>
  ///   Extension list for additional number reference properties.
  /// </summary>
  public NumRefExtensionList? NumRefExtensionList { get; set; }
}