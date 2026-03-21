namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the mathematical n-ary object, consisting of an n-ary object, a base (or operand), and optional upper limits and lower limits.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathnary?view=word-pia"/>
public interface OMathNary : InteropObject
{
  /// <summary>
  /// The sub.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathnary.sub?view=word-pia"/>
  public OMath Sub { get; }
  /// <summary>
  /// The sup.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathnary.sup?view=word-pia"/>
  public OMath Sup { get; }
  /// <summary>
  /// The e.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathnary.e?view=word-pia"/>
  public OMath E { get; }
  /// <summary>
  /// The char.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathnary.char?view=word-pia"/>
  public short Char { get; set; }
  /// <summary>
  /// The grow.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathnary.grow?view=word-pia"/>
  public bool Grow { get; set; }
  /// <summary>
  /// The sub sup lim.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathnary.subsuplim?view=word-pia"/>
  public bool SubSupLim { get; set; }
  /// <summary>
  /// The hide sub.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathnary.hidesub?view=word-pia"/>
  public bool HideSub { get; set; }
  /// <summary>
  /// The hide sup.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathnary.hidesup?view=word-pia"/>
  public bool HideSup { get; set; }

}
