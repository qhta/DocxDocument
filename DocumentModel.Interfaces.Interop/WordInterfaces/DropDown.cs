namespace DocumentModel.Interop;

/// <summary>
/// Represents a drop-down form field that contains a list of items in a form.
/// </summary>
public interface DropDown : InteropObject
{
  /// <summary>
  /// The valid.
  /// </summary>
  public bool Valid { get; }
  /// <summary>
  /// The default.
  /// </summary>
  public int Default { get; set; }
  /// <summary>
  /// The value.
  /// </summary>
  public int Value { get; set; }
  /// <summary>
  /// The list entries.
  /// </summary>
  public ListEntries ListEntries { get; }

}
