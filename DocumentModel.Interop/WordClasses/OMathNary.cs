namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the mathematical n-ary object, consisting of an n-ary object, a base (or operand), and optional upper limits and lower limits.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathnary?view=word-pia"/>
public class OMathNary : InteropObject
{
  /// <summary>
  /// Returns the subscript expression.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathnary.sub?view=word-pia"/>
  public OMath Sub { get; set; }
  /// <summary>
  /// Returns the superscript expression.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathnary.sup?view=word-pia"/>
  public OMath Sup { get; set; }
  /// <summary>
  /// Returns the base expression.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathnary.e?view=word-pia"/>
  public OMath E { get; set; }
  /// <summary>
  /// Returns or sets the n-ary operator character.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathnary.char?view=word-pia"/>
  public short Char { get; set; }
  /// <summary>
  /// Returns or sets whether the operator grows to fit the expression.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathnary.grow?view=word-pia"/>
  public bool Grow { get; set; }
  /// <summary>
  /// Returns or sets whether limits are displayed as subscript and superscript.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathnary.subsuplim?view=word-pia"/>
  public bool SubSupLim { get; set; }
  /// <summary>
  /// Returns or sets whether the subscript is hidden.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathnary.hidesub?view=word-pia"/>
  public bool HideSub { get; set; }
  /// <summary>
  /// Returns or sets whether the superscript is hidden.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathnary.hidesup?view=word-pia"/>
  public bool HideSup { get; set; }

}
