namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat?view=word-pia"/>
public partial interface ThreeDFormat
{
  /// <summary>
  /// Increments the rotation of the 3-D format around the x-axis.
  /// </summary>
  /// <param name="Increment">The amount to increment the rotation, in degrees.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.threedformat.incrementrotationx?view=word-pia"/>
  public void IncrementRotationX(float Increment);
}
