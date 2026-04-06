namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.editors?view=word-pia"/>
public partial interface IEditors: IModelObject
{
  /// <summary>
  /// Returns the value produced by the item operation.
  /// </summary>
  /// <param name="Index">Specifies the index.</param>
  /// <returns>The resulting value.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.editors.item?view=word-pia"/>
  public IEditor Item(object Index);
}
