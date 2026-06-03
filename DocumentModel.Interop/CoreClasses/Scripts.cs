using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of HTML script blocks in a document.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.scripts?view=office-pia"/>
public partial class Scripts: InteropCollection<Script>
{


  #region methods

/// <summary>
  /// Adds a script to the collection.
  /// </summary>
  /// <param name="anchor">The optional anchor for script placement.</param>
  /// <param name="location">The script anchor location.</param>
  /// <param name="language">The script language.</param>
  /// <param name="id">The script ID attribute.</param>
  /// <param name="extended">Additional script tag attributes.</param>
  /// <param name="scriptText">The script content.</param>
  /// <returns>The added script.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.scripts.add?view=office-pia"/>
  public Script Add(object anchor, ScriptLocation location,
    ScriptLanguage language, string id, string extended,
    string scriptText) { throw new NotImplementedException(); }
  /// <summary>
  /// Deletes all scripts in the collection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.scripts.delete?view=office-pia"/>
  public void Delete() { throw new NotImplementedException(); }

  #endregion methods
}

