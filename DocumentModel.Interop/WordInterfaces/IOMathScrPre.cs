namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an equation that contains a superscript or subscript to the left of the base.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrpre?view=word-pia"/>
public interface IOMathScrPre : IInteropObject
{
  /// <summary>
  /// Returns the subscript expression to the left of the base.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrpre.sub?view=word-pia"/>
  public OMath Sub { get; }

  /// <summary>
  /// Returns the superscript expression to the left of the base.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrpre.sup?view=word-pia"/>
  public OMath Sup { get; }

  /// <summary>
  /// Returns the base expression.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrpre.e?view=word-pia"/>
  public OMath E { get; }


  #region methods

/// <summary>
  /// Creates a new script function with both subscript and superscript components based on the current mathematical
  /// object.
  /// </summary>
  /// <remarks>Use this method to convert the current mathematical object into a form that displays both
  /// subscript and superscript, such as for mathematical notations like x_i^j. The returned object allows further
  /// customization of the subscript and superscript values.</remarks>
  /// <returns>An instance of the OMathFunction representing the script function with subscript and superscript applied.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathscrpre.toscrsubsup?view=word-pia"/>
  public OMathFunction ToScrSubSup();

  #endregion methods
}
