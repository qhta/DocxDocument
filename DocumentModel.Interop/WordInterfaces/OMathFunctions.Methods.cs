namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunctions?view=word-pia"/>
public partial interface OMathFunctions
{
  /// <summary>
  /// Adds a new mathematical function to the collection.
  /// </summary>
  /// <param name="Range">The range to which the function is added.</param>
  /// <param name="Type">The type of mathematical function to add.</param>
  /// <param name="NumArgs">The number of arguments for the function.</param>
  /// <param name="NumCols">The number of columns for the function, if applicable.</param>
  /// <returns>The created <see cref="OMathFunction"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunctions.add?view=word-pia"/>
  public OMathFunction Add(Range Range, WdOMathFunctionType Type, object NumArgs, object NumCols);
}
