namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a fraction, consisting of a numerator and denominator separated by a fraction bar. The fraction bar can be horizontal or diagonal, depending on the fraction properties.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfrac?view=word-pia"/>
public interface IOMathFrac : IModelObject
{
  /// <summary>
  /// Returns the numerator expression.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfrac.num?view=word-pia"/>
  public IOMath Num { get; }
  /// <summary>
  /// Returns the denominator expression.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfrac.den?view=word-pia"/>
  public IOMath Den { get; }
  /// <summary>
  /// Returns or sets the fraction type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfrac.type?view=word-pia"/>
  public OMathFracType Type { get; set; }

}
