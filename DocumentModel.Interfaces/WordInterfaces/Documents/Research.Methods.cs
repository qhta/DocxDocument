namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.research?view=word-pia"/>
public partial interface Research: InteropObject
{
  /// <summary>
  /// Executes a query against the specified service using the provided query string and language settings.
  /// </summary>
  /// <param name="ServiceID">The unique identifier of the service to which the query is directed.</param>
  /// <param name="QueryString">The query to execute against the service. The format and content depend on the service's requirements.</param>
  /// <param name="QueryLanguage">The language identifier specifying the language context for the query.</param>
  /// <param name="UseSelection">true if the current selection should be used as part of the query context; otherwise, false.</param>
  /// <param name="LaunchQuery">true to launch the query immediately; otherwise, false to prepare the query without executing it.</param>
  /// <returns>An object containing the result of the query. The type and structure of the result depend on the service and query
  /// executed.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.research.query?view=word-pia"/>
  public object Query(string ServiceID, string QueryString, LanguageID QueryLanguage, bool UseSelection, bool LaunchQuery);
}
