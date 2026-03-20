using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of HTML script blocks in a document.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.scripts?view=office-pia
/// </remarks>
public partial interface Scripts
{
  /// <summary>
  /// Returns a script by name, ID, or index.
  /// </summary>
  /// <param name="Index">The script name, ID, or index.</param>
  /// <returns>The requested script.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.scripts.item?view=office-pia
  /// </remarks>
  public Script Item(object Index);
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
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.scripts.add?view=office-pia
  /// </remarks>
  public Script Add
  (object Anchor, MsoScriptLocation Location,
    MsoScriptLanguage Language, string Id, string Extended,
    string ScriptText);
  /// <summary>
  /// Deletes all scripts in the collection.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.scripts.delete?view=office-pia
  /// </remarks>
  public void Delete();
}
