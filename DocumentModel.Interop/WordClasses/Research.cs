namespace DocumentModel.Interop.Word;

/// <summary>
/// Provides access to the research service feature of Microsoft Office Word.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.research?view=word-pia"/>
public partial class Research : InteropObject
{
  /// <summary>
  /// Gets or sets a string that specifies the favorite research service.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.research.favoriteservice?view=word-pia"/>
  public string? FavoriteService { get; set; }


  #region methods

/// <summary>
  /// Executes a query against the specified service using the provided query string and language settings.
  /// </summary>
  /// <param name="serviceID">The unique identifier of the service to which the query is directed.</param>
  /// <param name="queryString">The query to execute against the service. The format and content depend on the service's requirements.</param>
  /// <param name="queryLanguage">The language identifier specifying the language context for the query.</param>
  /// <param name="useSelection">true if the current selection should be used as part of the query context; otherwise, false.</param>
  /// <param name="launchQuery">true to launch the query immediately; otherwise, false to prepare the query without executing it.</param>
  /// <returns>An object containing the result of the query. The type and structure of the result depend on the service and query
  /// executed.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.research.query?view=word-pia"/>
  public object Query(string serviceID, string queryString, LanguageID queryLanguage, bool useSelection, bool launchQuery) { throw new NotImplementedException(); }

  #endregion methods
}
