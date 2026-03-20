using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// A collection of DocumentProperty objects.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentproperties?view=office-pia
/// </remarks>
public partial interface DocumentProperties
{
  /// <summary>
  /// Adds a new document property to the collection.
  /// </summary>
  /// <param name="Name">The `Name` parameter.</param>
  /// <param name="LinkToContent">The `LinkToContent` parameter.</param>
  /// <param name="Type">The `Type` parameter.</param>
  /// <param name="Value">The `Value` parameter.</param>
  /// <param name="LinkSource">The `LinkSource` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentproperties.add?view=office-pia
  /// </remarks>
  public DocumentProperty Add(string Name, bool LinkToContent, object Type, object Value, object LinkSource);
  /// <summary>
  /// Returns an enumerator for the document properties collection.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentproperties.getenumerator?view=office-pia
  /// </remarks>
  public new IEnumerator GetEnumerator();
}
