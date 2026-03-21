namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Field objects that represent all the fields in a selection, range, or document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fields?view=word-pia"/>
public partial interface Fields : InteropObject, InteropCollection<Field>
{
  /// <summary>
  /// The locked.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fields.locked?view=word-pia"/>
  public int Locked { get; set; }
}
