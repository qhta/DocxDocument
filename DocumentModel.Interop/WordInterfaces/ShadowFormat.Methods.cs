namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shadowformat?view=word-pia"/>
public partial interface ShadowFormat
{
  /// <summary>
  /// Increments the shadow's horizontal offset by the specified amount.
  /// </summary>
  /// <param name="Increment">The amount to increment the horizontal offset.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shadowformat.incrementoffsetx?view=word-pia"/>
  public void IncrementOffsetX(float Increment);
}
