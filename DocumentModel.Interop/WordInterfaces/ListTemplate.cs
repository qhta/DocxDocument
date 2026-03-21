namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single list template that includes all the formatting that defines a list.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listtemplate?view=word-pia"/>
public partial interface ListTemplate : InteropObject
{
  /// <summary>
  /// The outline numbered.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listtemplate.outlinenumbered?view=word-pia"/>
  public bool OutlineNumbered { get; set; }

  /// <summary>
  /// The name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listtemplate.name?view=word-pia"/>
  public string Name { get; set; }

  /// <summary>
  /// The list levels.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listtemplate.listlevels?view=word-pia"/>
  public ListLevels ListLevels { get; }
}
