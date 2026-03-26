namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunctions?view=word-pia"/>
public partial interface OMathFunctions: InteropObject
{
  /// <summary>
  /// Adds an equation function to the collection.
  /// </summary>
  /// <param name="Range">Specifies the range where the function is inserted.</param>
  /// <param name="Type">Specifies the equation function type.</param>
  /// <param name="NumArgs">Specifies the number of arguments.</param>
  /// <param name="NumCols">Specifies the number of columns, when applicable.</param>
  /// <returns>The added equation function object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunctions.add?view=word-pia"/>
  public OMathFunction Add(Range Range, OMathFunctionType Type, object NumArgs, object NumCols);
}
