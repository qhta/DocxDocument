namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the upper limit mathematical construct, consisting of text on the baseline and reduced-size text immediately above it.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathlimupp?view=word-pia"/>
public partial interface OMathLimUpp : InteropObject
{
  /// <summary>
  /// Returns the e.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathlimupp.e?view=word-pia"/>
  public OMath E { get; }

  /// <summary>
  /// Returns the lim.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathlimupp.lim?view=word-pia"/>
  public OMath Lim { get; }
}
