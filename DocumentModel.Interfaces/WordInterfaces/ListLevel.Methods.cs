namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel?view=word-pia"/>
public partial interface ListLevel
{
  /// <summary>
  /// Applies a picture bullet to the list level and returns the picture bullet shape.
  /// </summary>
  /// <param name="FileName">The file name of the picture to use as a bullet.</param>
  /// <returns>The <see cref="InlineShape"/> created for the picture bullet.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevel.applypicturebullet?view=word-pia"/>
  public InlineShape ApplyPictureBullet(string FileName);
}
