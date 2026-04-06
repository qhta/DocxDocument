namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the upper limit mathematical construct, consisting of text on the baseline and reduced-size text immediately above it.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathlimupp?view=word-pia"/>
public partial interface IOMathLimUpp : IModelObject
{
  /// <summary>
  /// Returns the base expression for the upper-limit construct.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathlimupp.e?view=word-pia"/>
  public IOMath E { get; }

  /// <summary>
  /// Returns the upper limit expression.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathlimupp.lim?view=word-pia"/>
  public IOMath Lim { get; }
}
