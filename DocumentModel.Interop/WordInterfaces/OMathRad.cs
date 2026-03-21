namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the mathematical radical object, consisting of a radical, a base, and an optional degree.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathrad?view=word-pia"/>
public interface OMathRad : InteropObject
{
  /// <summary>
  /// Returns the deg.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathrad.deg?view=word-pia"/>
  public OMath Deg { get; }
  /// <summary>
  /// Returns the e.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathrad.e?view=word-pia"/>
  public OMath E { get; }
  /// <summary>
  /// Returns or sets whether hide deg.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathrad.hidedeg?view=word-pia"/>
  public bool HideDeg { get; set; }

}
