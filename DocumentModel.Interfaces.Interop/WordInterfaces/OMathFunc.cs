namespace DocumentModel.Interop;

/// <summary>
/// Represents the application of a function or an argument in an equation that consists of a function name, such as sin or cos, and an argument.
/// </summary>
public interface OMathFunc : InteropObject
{
  /// <summary>
  /// The fname.
  /// </summary>
  public OMath FName { get; }
  /// <summary>
  /// The e.
  /// </summary>
  public OMath E { get; }

}
