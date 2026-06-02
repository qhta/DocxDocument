namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of equations. Use the OMaths object to access individual members of the collection.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omaths?view=word-pia"/>
public interface IOMaths : IInteropObject, IInteropCollection<OMath>
{


  #region methods

/// <summary>
  /// Converts all equations in the collection to linear format. .
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omaths.linearize?view=word-pia"/>
  public void Linearize();

  /// <summary>
  /// Converts all equations in the collection to professional format.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omaths.buildup?view=word-pia"/>
  public void BuildUp();

  /// <summary>
  /// Returns a new range that represents the sum of the current range and the specified range.
  /// </summary>
  /// <remarks>The resulting range may not be contiguous if the specified range does not overlap or is not
  /// adjacent to the current range. This method does not modify the current instance.</remarks>
  /// <param name="Range">The range to add to the current range. Must not be null.</param>
  /// <returns>A new Range instance representing the combined range of the current and specified ranges.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omaths.add?view=word-pia"/>
  public Range Add(Range Range);

  #endregion methods
}
