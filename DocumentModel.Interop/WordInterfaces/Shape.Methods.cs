namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape?view=word-pia"/>
public partial interface Shape
{
  /// <summary>
  /// Applies to the specified shape formatting that has been copied using the PickUp() method.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shape.apply?view=word-pia"/>
  public void Apply();
}
