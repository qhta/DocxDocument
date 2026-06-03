namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single list template that includes all the formatting that defines a list.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listtemplate?view=word-pia"/>
public interface IListTemplate : IInteropObject
{
  /// <summary>
  /// Returns or sets whether the list template is outline numbered.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listtemplate.outlinenumbered?view=word-pia"/>
  public bool OutlineNumbered { get; set; }

  /// <summary>
  /// Returns or sets the name of the list template.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listtemplate.name?view=word-pia"/>
  public string Name { get; set; }

  /// <summary>
  /// Returns the list levels collection for the list template.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listtemplate.listlevels?view=word-pia"/>
  public IListLevels IListLevels { get; }


  #region methods

/// <summary>
  /// Converts a list template to another list template type.
  /// </summary>
  /// <param name="level">Specifies the level used for conversion.</param>
  /// <returns>The converted list template.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listtemplate.convert?view=word-pia"/>
  public IListTemplate Convert(object level);

  #endregion methods
}
