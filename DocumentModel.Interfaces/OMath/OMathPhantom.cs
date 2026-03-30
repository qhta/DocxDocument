namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a phantom object, which has two primary uses: (1) adding the spacing of the phantom base without displaying that base or (2) suppressing part of the glyph from spacing considerations.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathphantom?view=word-pia"/>
public interface IOMathPhantom : IModelObject
{
  /// <summary>
  /// Returns the base expression for the phantom.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathphantom.e?view=word-pia"/>
  public IOMath E { get; }
  /// <summary>
  /// Returns or sets whether the phantom expression is shown.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathphantom.show?view=word-pia"/>
  public bool Show { get; set; }
  /// <summary>
  /// Returns or sets whether the phantom has zero width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathphantom.zerowid?view=word-pia"/>
  public bool ZeroWid { get; set; }
  /// <summary>
  /// Returns or sets whether the phantom has zero ascent.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathphantom.zeroasc?view=word-pia"/>
  public bool ZeroAsc { get; set; }
  /// <summary>
  /// Returns or sets whether the phantom has zero descent.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathphantom.zerodesc?view=word-pia"/>
  public bool ZeroDesc { get; set; }
  /// <summary>
  /// Returns or sets whether the phantom is transparent.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathphantom.transp?view=word-pia"/>
  public bool Transp { get; set; }
  /// <summary>
  /// Returns or sets whether the phantom is smashed for layout.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathphantom.smash?view=word-pia"/>
  public bool Smash { get; set; }

}
