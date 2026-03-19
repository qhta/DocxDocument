namespace DocumentModel.Interop.Word;

public partial interface OMaths
{
  /// <summary>
  /// Converts all equations in the collection to linear format. .
  /// </summary>
  public void Linearize();

  /// <summary>
  /// Converts all equations in the collection to professional format.
  /// </summary>
  public void BuildUp();

  /// <summary>
  /// Returns a new range that represents the sum of the current range and the specified range.
  /// </summary>
  /// <remarks>The resulting range may not be contiguous if the specified range does not overlap or is not
  /// adjacent to the current range. This method does not modify the current instance.</remarks>
  /// <param name="Range">The range to add to the current range. Must not be null.</param>
  /// <returns>A new Range instance representing the combined range of the current and specified ranges.</returns>
  public Range Add(Range Range);
}
