namespace DocumentModel.Interop.Word;

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
  public OMathFunction Add(Range Range, WdOMathFunctionType Type, object NumArgs, object NumCols);
}
