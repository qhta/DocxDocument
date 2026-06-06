namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the collection of equation function objects.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunctions?view=word-pia"/>
public interface IMathFunctions : IInteropObject, IInteropCollection<IMathFunction>
{


  #region methods

/// <summary>
  /// Adds an equation function to the collection.
  /// </summary>
  /// <param name="range">Specifies the range where the function is inserted.</param>
  /// <param name="type">Specifies the equation function type.</param>
  /// <param name="numArgs">Specifies the number of arguments.</param>
  /// <param name="numCols">Specifies the number of columns, when applicable.</param>
  /// <returns>The added equation function object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathfunctions.add?view=word-pia"/>
  public IMathFunction Add(IRange range, MathFunctionType type, object numArgs, object numCols);

  #endregion methods
}

