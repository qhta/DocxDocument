namespace DocumentModel.Interop.Word;	
/// <summary>
/// Represents a single table of authorities category.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofauthoritiescategory?view=word-pia"/>
public interface ITableOfAuthoritiesCategory : IInteropObject
{
  /// <summary>
  /// Returns or sets the name of the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofauthoritiescategory.name?view=word-pia"/>
  public string Name { get; set; }
  /// <summary>
  /// Returns an Integer that represents the position of an item in a collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofauthoritiescategory.index?view=word-pia"/>
  public int Index { get; }	
}
