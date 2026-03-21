namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the lower limit mathematical construct, consisting of text on the baseline and reduced-size text immediately below it.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathlimlow?view=word-pia"/>
public partial interface OMathLimLow : InteropObject
{
  /// <summary>
  /// Returns the e.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathlimlow.e?view=word-pia"/>
  public OMath E { get; }

  /// <summary>
  /// Returns the lim.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathlimlow.lim?view=word-pia"/>
  public OMath Lim { get; }
}
