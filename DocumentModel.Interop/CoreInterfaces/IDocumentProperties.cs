using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// A collection of DocumentProperty objects.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentproperties?view=office-pia"/>
public interface IDocumentProperties: IInteropCollection<IDocumentProperty>
{


  #region methods

/// <summary>
  /// Adds a new document property to the collection.
  /// </summary>
  /// <param name="name">The `Name` parameter.</param>
  /// <param name="linkToContent">The `LinkToContent` parameter.</param>
  /// <param name="type">The `Type` parameter.</param>
  /// <param name="value">The `Value` parameter.</param>
  /// <param name="linkSource">The `LinkSource` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentproperties.add?view=office-pia"/>
  public IDocumentProperty Add(string name, bool linkToContent, object type, object value, object linkSource);
  /// <summary>
  /// Returns an enumerator for the document properties collection.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.documentproperties.getenumerator?view=office-pia"/>
  public new IEnumerator GetEnumerator();

  #endregion methods
}

