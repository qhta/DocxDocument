namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the upper limit mathematical construct, consisting of text on the baseline and reduced-size text immediately above it.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathlimupp?view=word-pia"/>
public interface IOMathLimUpp : IInteropObject
{
  /// <summary>
  /// Returns the base expression for the upper-limit construct.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathlimupp.e?view=word-pia"/>
  public IOMath E { get; }

  /// <summary>
  /// Returns the upper limit expression.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathlimupp.lim?view=word-pia"/>
  public IOMath Lim { get; }


  #region methods

/// <summary>
  /// Converts the upper-limit construct to a lower-limit construct.
  /// </summary>
  /// <returns>The resulting equation function object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathlimupp.tolimlow?view=word-pia"/>
  public IOMathFunction ToLimLow();

  #endregion methods
}
