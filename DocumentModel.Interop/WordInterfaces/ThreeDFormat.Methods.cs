namespace DocumentModel.Interop.Word;

public partial interface ThreeDFormat
{
  /// <summary>
  /// Increments the rotation of the 3-D format around the x-axis.
  /// </summary>
  /// <param name="Increment">The amount to increment the rotation, in degrees.</param>
  public void IncrementRotationX(float Increment);
}
