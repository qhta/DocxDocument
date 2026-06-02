namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the lower limit mathematical construct, consisting of text on the baseline and reduced-size text immediately below it.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathlimlow?view=word-pia"/>
public partial interface IOMathLimLow : IInteropObject
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


  #region methods

/// <summary>
  /// Converts the lower-limit construct to an upper-limit construct.
  /// </summary>
  /// <returns>The resulting equation function object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathlimlow.tolimupp?view=word-pia"/>
  public OMathFunction ToLimUpp();

  #endregion methods
}
