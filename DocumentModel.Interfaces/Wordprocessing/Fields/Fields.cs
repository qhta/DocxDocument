namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of Field objects that represent all the fields in a selection, range, or document.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fields?view=word-pia"/>
public partial interface IFields : IModelCollection<Field>
{
  /// <summary>
  /// Determines if all fields in the <see cref="IFields"/> collection are locked.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.fields.locked?view=word-pia"/>
  public int Locked { get; set; }
}
