using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `CustomXMLValidationErrors` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlvalidationerrors?view=office-pia` for Office interop details.
/// </remarks>
/// <summary>
/// Represents a collection of CustomXMLValidationError objects.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlvalidationerrors?view=office-pia"/>
public interface ICustomXMLValidationErrors: IInteropCollection<ICustomXMLValidationError>
{


  #region methods

/// <summary>
  /// Adds a validation error entry to the collection.
  /// </summary>
  /// <param name="node">The `Node` parameter.</param>
  /// <param name="errorName">The `ErrorName` parameter.</param>
  /// <param name="errorText">The `ErrorText` parameter.</param>
  /// <param name="clearedOnUpdate">The `ClearedOnUpdate` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlvalidationerrors.add?view=office-pia"/>
  public void Add(ICustomXMLNode node, string errorName, string errorText, bool clearedOnUpdate);

  #endregion methods
}

