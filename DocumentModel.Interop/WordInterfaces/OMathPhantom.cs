namespace DocumentModel.Interop;

/// <summary>
/// Represents a phantom object, which has two primary uses: (1) adding the spacing of the phantom base without displaying that base or (2) suppressing part of the glyph from spacing considerations.
/// </summary>
public interface OMathPhantom : InteropObject
{
  /// <summary>
  /// The e.
  /// </summary>
  public OMath E { get; }
  /// <summary>
  /// The show.
  /// </summary>
  public bool Show { get; set; }
  /// <summary>
  /// The zero wid.
  /// </summary>
  public bool ZeroWid { get; set; }
  /// <summary>
  /// The zero asc.
  /// </summary>
  public bool ZeroAsc { get; set; }
  /// <summary>
  /// The zero desc.
  /// </summary>
  public bool ZeroDesc { get; set; }
  /// <summary>
  /// The transp.
  /// </summary>
  public bool Transp { get; set; }
  /// <summary>
  /// The smash.
  /// </summary>
  public bool Smash { get; set; }

}
