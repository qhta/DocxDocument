using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of HTML script blocks in a document.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.scripts?view=office-pia"/>
public partial class Scripts
{
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
  public Script Add(object Anchor, ScriptLocation Location,
    ScriptLanguage Language, string Id, string Extended,
    string ScriptText) { throw new NotImplementedException(); }
  /// <summary>
  /// Deletes all scripts in the collection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.scripts.delete?view=office-pia"/>
  public void Delete() { throw new NotImplementedException(); }
}

