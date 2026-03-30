namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font?view=word-pia"/>
public partial interface IFont
{
  /// <summary>
  /// Increases the font size to the next available size. If the selection or range contains more than one font
  /// size, each size is increased to the next available setting.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word._font.grow?view=word-pia"/>
  public void Grow();
}
