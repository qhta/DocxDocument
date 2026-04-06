namespace DocumentModel.Wordprocessing;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.list?view=word-pia"/>
public partial interface IList: IModelObject
{
  /// <summary>
  /// Converts list numbers and LISTNUM fields in the list to text.
  /// </summary>
  /// <param name="NumberType">The type of number format to convert.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.list.convertnumberstotext?view=word-pia"/>
  public void ConvertNumbersToText(NumberType NumberType);
}
