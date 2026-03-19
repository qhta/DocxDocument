namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single check box form field.
/// </summary>
public interface CheckBox : InteropObject
{
  /// <summary>
  /// The valid.
  /// </summary>
  public bool Valid { get; }
  /// <summary>
  /// The auto size.
  /// </summary>
  public bool AutoSize { get; set; }
  /// <summary>
  /// The size.
  /// </summary>
  public float Size { get; set; }
  /// <summary>
  /// The default.
  /// </summary>
  public bool Default { get; set; }
  /// <summary>
  /// The value.
  /// </summary>
  public bool Value { get; set; }

}
