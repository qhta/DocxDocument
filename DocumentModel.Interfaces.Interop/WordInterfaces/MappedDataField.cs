namespace DocumentModel.Interop;

/// <summary>
/// Represents a single mapped data field.
/// </summary>
public interface MappedDataField : InteropObject
{
  /// <summary>
  /// The index.
  /// </summary>
  public int Index { get; }
  /// <summary>
  /// The data field name.
  /// </summary>
  public string DataFieldName { get; }
  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; }
  /// <summary>
  /// The value.
  /// </summary>
  public string Value { get; }
  /// <summary>
  /// The data field index.
  /// </summary>
  public int DataFieldIndex { get; set; }

}
