namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the mathematical radical object, consisting of a radical, a base, and an optional degree.
/// </summary>
public interface OMathRad : InteropObject
{
  /// <summary>
  /// The deg.
  /// </summary>
  public OMath Deg { get; }
  /// <summary>
  /// The e.
  /// </summary>
  public OMath E { get; }
  /// <summary>
  /// The hide deg.
  /// </summary>
  public bool HideDeg { get; set; }

}
