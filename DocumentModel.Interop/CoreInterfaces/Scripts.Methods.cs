using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `Scripts` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.scripts?view=office-pia` for Office interop details.
/// </remarks>
public partial interface Scripts
{
  /// <summary>
  /// Invokes `Item`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.scripts.item?view=office-pia
  /// </remarks>
  public Script Item(object Index);
  /// <summary>
  /// Invokes `Add`.
  /// </summary>
  /// <param name="Anchor">The `Anchor` parameter.</param>
  /// <param name="Location">The `Location` parameter.</param>
  /// <param name="Language">The `Language` parameter.</param>
  /// <param name="Id">The `Id` parameter.</param>
  /// <param name="Extended">The `Extended` parameter.</param>
  /// <param name="ScriptText">The `ScriptText` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.scripts.add?view=office-pia
  /// </remarks>
  public Script Add
  (object Anchor, MsoScriptLocation Location,
    MsoScriptLanguage Language, string Id, string Extended,
    string ScriptText);
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.scripts.delete?view=office-pia
  /// </remarks>
  public void Delete();
}
