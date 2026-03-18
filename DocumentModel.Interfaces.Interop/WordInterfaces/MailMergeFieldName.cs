namespace DocumentModel.Interop;

/// <summary>
/// Represents a mail merge field name in a data source.
/// </summary>
public interface MailMergeFieldName : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; }
  /// <summary>
  /// The index.
  /// </summary>
  public int Index { get; }

}
