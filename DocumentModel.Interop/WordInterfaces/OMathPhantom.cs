namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a phantom object, which has two primary uses: (1) adding the spacing of the phantom base without displaying that base or (2) suppressing part of the glyph from spacing considerations.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathphantom?view=word-pia"/>
public interface OMathPhantom : InteropObject
{
  /// <summary>
  /// Returns the e.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathphantom.e?view=word-pia"/>
  public OMath E { get; }
  /// <summary>
  /// Returns or sets whether show.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathphantom.show?view=word-pia"/>
  public bool Show { get; set; }
  /// <summary>
  /// Returns or sets whether zero wid.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathphantom.zerowid?view=word-pia"/>
  public bool ZeroWid { get; set; }
  /// <summary>
  /// Returns or sets whether zero asc.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathphantom.zeroasc?view=word-pia"/>
  public bool ZeroAsc { get; set; }
  /// <summary>
  /// Returns or sets whether zero desc.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathphantom.zerodesc?view=word-pia"/>
  public bool ZeroDesc { get; set; }
  /// <summary>
  /// Returns or sets whether transp.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathphantom.transp?view=word-pia"/>
  public bool Transp { get; set; }
  /// <summary>
  /// Returns or sets whether smash.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathphantom.smash?view=word-pia"/>
  public bool Smash { get; set; }

}
