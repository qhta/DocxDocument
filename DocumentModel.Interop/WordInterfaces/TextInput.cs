namespace DocumentModel.Interop;

/// <summary>
/// Represents a single text form field.
/// </summary>
public partial interface TextInput : InteropObject
{
  /// <summary>
  /// The valid.
  /// </summary>
  public bool Valid { get; }

  /// <summary>
  /// The default.
  /// </summary>
  public string Default { get; set; }

  /// <summary>
  /// The type.
  /// </summary>
  public WdTextFormFieldType Type { get; }

  /// <summary>
  /// The format.
  /// </summary>
  public string Format { get; }

  /// <summary>
  /// The width.
  /// </summary>
  public int Width { get; set; }
}
