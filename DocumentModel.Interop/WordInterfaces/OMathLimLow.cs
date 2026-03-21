namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the lower limit mathematical construct, consisting of text on the baseline and reduced-size text immediately below it.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathlimlow?view=word-pia"/>
public partial interface OMathLimLow : InteropObject
{
  /// <summary>
  /// The e.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathlimlow.e?view=word-pia"/>
  public OMath E { get; }

  /// <summary>
  /// The lim.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathlimlow.lim?view=word-pia"/>
  public OMath Lim { get; }
}
