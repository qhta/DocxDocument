namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single mail merge field in a data source.
/// </summary>
public interface MailMergeDataField : InteropObject
{
  /// <summary>
  /// The value.
  /// </summary>
  public string Value { get; }
  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; }
  /// <summary>
  /// The index.
  /// </summary>
  public int Index { get; }

}
