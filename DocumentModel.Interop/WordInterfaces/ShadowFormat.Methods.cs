namespace DocumentModel.Interop.Word;

public partial interface ShadowFormat
{
  /// <summary>
  /// Increments the shadow's horizontal offset by the specified amount.
  /// </summary>
  /// <param name="Increment">The amount to increment the horizontal offset.</param>
  public void IncrementOffsetX(float Increment);
}
