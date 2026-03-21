namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the mathematical n-ary object, consisting of an n-ary object, a base (or operand), and optional upper limits and lower limits.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathnary?view=word-pia"/>
public interface OMathNary : InteropObject
{
  /// <summary>
  /// Returns the sub.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathnary.sub?view=word-pia"/>
  public OMath Sub { get; }
  /// <summary>
  /// Returns the sup.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathnary.sup?view=word-pia"/>
  public OMath Sup { get; }
  /// <summary>
  /// Returns the e.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathnary.e?view=word-pia"/>
  public OMath E { get; }
  /// <summary>
  /// Returns or sets the char.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathnary.char?view=word-pia"/>
  public short Char { get; set; }
  /// <summary>
  /// Returns or sets whether grow.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathnary.grow?view=word-pia"/>
  public bool Grow { get; set; }
  /// <summary>
  /// Returns or sets whether sub sup lim.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathnary.subsuplim?view=word-pia"/>
  public bool SubSupLim { get; set; }
  /// <summary>
  /// Returns or sets whether hide sub.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathnary.hidesub?view=word-pia"/>
  public bool HideSub { get; set; }
  /// <summary>
  /// Returns or sets whether hide sup.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathnary.hidesup?view=word-pia"/>
  public bool HideSup { get; set; }

}
