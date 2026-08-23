using DocumentModel.HTML;

namespace DocumentModel.Application;

/// <summary>
/// Represents a collection of HTML script blocks in a document.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.scripts?view=office-pia"/>
public partial interface IScripts
{
  /// <summary>
  /// Returns a script by name, ID, or index.
  /// </summary>
  /// <param name="Index">The script name, ID, or index.</param>
  /// <returns>The requested script.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.scripts.item?view=office-pia"/>
  public IScript Item(object Index);
  /// <summary>
  /// Adds a script to the collection.
  /// </summary>
  /// <param name="Anchor">The optional anchor for script placement.</param>
  /// <param name="Location">The script anchor location.</param>
  /// <param name="Language">The script language.</param>
  /// <param name="Id">The script ID attribute.</param>
  /// <param name="Extended">Additional script tag attributes.</param>
  /// <param name="ScriptText">The script content.</param>
  /// <returns>The added script.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.scripts.add?view=office-pia"/>
  public IScript Add
  (object Anchor, ScriptLocation Location,
    ScriptLanguage Language, string Id, string Extended,
    string ScriptText);
  /// <summary>
  /// Deletes all scripts in the collection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.scripts.delete?view=office-pia"/>
  public void Delete();
}

