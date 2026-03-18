namespace DocumentModel.Interop;

public partial interface ListLevel
{
  /// <summary>
  /// Applies a picture bullet to the list level.
  /// </summary>
  /// <param name="FileName">The file name of the picture to use as a bullet.</param>
  /// <returns>The <see cref="InlineShape"/> created for the picture bullet.</returns>
  public InlineShape ApplyPictureBullet(string FileName);
}
