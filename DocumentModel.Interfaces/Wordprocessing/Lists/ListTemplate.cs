namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a single list template that includes all the formatting that defines a list.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listtemplate?view=word-pia"/>
public partial interface IListTemplate : IModelObject
{
  /// <summary>
  /// Returns or sets whether the list template is outline numbered.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listtemplate.outlinenumbered?view=word-pia"/>
  public bool OutlineNumbered { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the name of the list template.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listtemplate.name?view=word-pia"/>
  public string Name { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns the list levels collection for the list template.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listtemplate.listlevels?view=word-pia"/>
  public IListLevels ListLevels { get; }
}
