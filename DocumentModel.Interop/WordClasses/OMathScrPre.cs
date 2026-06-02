namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an equation that contains a superscript or subscript to the left of the base.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrpre?view=word-pia"/>
public partial class OMathScrPre : InteropObject
{
  /// <summary>
  /// Returns the subscript expression to the left of the base.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrpre.sub?view=word-pia"/>
  public OMath Sub { get; set; }

  /// <summary>
  /// Returns the superscript expression to the left of the base.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrpre.sup?view=word-pia"/>
  public OMath Sup { get; set; }

  /// <summary>
  /// Returns the base expression.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrpre.e?view=word-pia"/>
  public OMath E { get; set; }
}
