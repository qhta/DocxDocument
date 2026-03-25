namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the upper limit mathematical construct, consisting of text on the baseline and reduced-size text immediately above it.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathlimupp?view=word-pia"/>
public partial interface OMathLimUpp : InteropObject
{
  /// <summary>
  /// Returns the base expression for the upper-limit construct.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathlimupp.e?view=word-pia"/>
  public OMath E { get; }

  /// <summary>
  /// Returns the upper limit expression.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathlimupp.lim?view=word-pia"/>
  public OMath Lim { get; }
}
