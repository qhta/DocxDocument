namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.page?view=word-pia"/>
public partial interface IPage: IModelObject
{
  /// <summary>
  /// Executes the save as png operation.
  /// </summary>
  /// <param name="FileName">Specifies the file name.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.page.saveaspng?view=word-pia"/>
  public void SaveAsPNG(string FileName);
}
