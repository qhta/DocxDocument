namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a fraction, consisting of a numerator and denominator separated by a fraction bar. The fraction bar can be horizontal or diagonal, depending on the fraction properties.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfrac?view=word-pia"/>
public interface OMathFrac : InteropObject
{
  /// <summary>
  /// The num.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfrac.num?view=word-pia"/>
  public OMath Num { get; }
  /// <summary>
  /// The den.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfrac.den?view=word-pia"/>
  public OMath Den { get; }
  /// <summary>
  /// The type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfrac.type?view=word-pia"/>
  public WdOMathFracType Type { get; set; }

}
