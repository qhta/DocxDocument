namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents all chart categories in the document, whether visible (unfiltered) or not.
/// </summary>
public interface ChartCategory : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; }
  /// <summary>
  /// The is filtered.
  /// </summary>
  public bool IsFiltered { get; set; }

}
