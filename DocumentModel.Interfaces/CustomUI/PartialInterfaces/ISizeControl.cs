namespace DocumentModel;

/// <summary>
/// Defines members that allow a control's size to be specified directly or determined dynamically by a callback
/// function.
/// </summary>
/// <remarks>Implementations of this interface support two mutually exclusive mechanisms for controlling size:
/// setting a fixed size or specifying a callback to determine the size at runtime. If neither mechanism is used, the
/// control defaults to its normal size.</remarks>
public interface ISizeControl
{
  /// <summary>
  ///   Specifies the size of the control.
  ///
  /// The size and getSize attributes are mutually exclusive.If neither attribute is specified, the control's size SHOULD default to the normal size.
  /// </summary>
  public SizeKind? Size { get; set; }

  /// <summary>
  ///   Specifies the name of a callback function to be called to determine the size of this control.
  ///
  ///  The getSize and size attributes are mutually exclusive.If neither attribute is specified, the control's size SHOULD default to the normal size.
  /// </summary>
  public string? GetSize { get; set; }
}