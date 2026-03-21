namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single table of authorities category.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofauthoritiescategory?view=word-pia"/>
public interface TableOfAuthoritiesCategory : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofauthoritiescategory.name?view=word-pia"/>
  public string Name { get; set; }
  /// <summary>
  /// The index.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tableofauthoritiescategory.index?view=word-pia"/>
  public int Index { get; }

}
