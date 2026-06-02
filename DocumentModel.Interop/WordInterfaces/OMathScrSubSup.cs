namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an equation with a base that contains a superscript or subscript.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrsubsup?view=word-pia"/>
public partial interface IOMathScrSubSup : IInteropObject
{
  /// <summary>
  /// Returns the base expression.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrsubsup.e?view=word-pia"/>
  public OMath E { get; }

  /// <summary>
  /// Returns the subscript expression.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrsubsup.sub?view=word-pia"/>
  public OMath Sub { get; }

  /// <summary>
  /// Returns the superscript expression.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrsubsup.sup?view=word-pia"/>
  public OMath Sup { get; }

  /// <summary>
  /// Returns or sets whether the scripts are aligned.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrsubsup.alignscripts?view=word-pia"/>
  public bool AlignScripts { get; set; }


  #region methods

/// <summary>
  /// Removes the subscript-superscript formatting from the equation function.
  /// </summary>
  /// <returns>The resulting equation function object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrsubsup.removesub?view=word-pia"/>
  public OMathFunction RemoveSub();

  #endregion methods
}
