namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the lower limit mathematical construct, consisting of text on the baseline and reduced-size text immediately below it.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathlimlow?view=word-pia"/>
public partial interface OMathLimLow : IModelObject
{
  /// <summary>
  /// Returns the base expression for the lower-limit construct.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathlimlow.e?view=word-pia"/>
  public OMath E { get; }

  /// <summary>
  /// Returns the lower limit expression.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathlimlow.lim?view=word-pia"/>
  public OMath Lim { get; }
}
