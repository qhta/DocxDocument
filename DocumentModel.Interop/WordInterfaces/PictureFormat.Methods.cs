namespace DocumentModel.Interop.Word;

public partial interface PictureFormat
{
  /// <summary>
  /// Increases the current brightness level by the specified amount.
  /// </summary>
  /// <param name="Increment">The amount by which to increase the brightness. Must be a positive value.</param>
  public void IncrementBrightness(float Increment);
}
