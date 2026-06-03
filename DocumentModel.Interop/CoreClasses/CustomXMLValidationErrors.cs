using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `CustomXMLValidationErrors` class.
/// </summary>
/// <remarks>
/// See `http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlvalidationerrors?view=office-pia` for Office interop details.
/// </remarks>
/// <summary>
/// Represents a collection of CustomXMLValidationError objects.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlvalidationerrors?view=office-pia"/>
public partial class CustomXMLValidationErrors: InteropCollection<CustomXMLValidationError>
{


  #region methods

/// <summary>
  /// Adds a validation error entry to the collection.
  /// </summary>
  /// <param name="node">The `Node` parameter.</param>
  /// <param name="errorName">The `ErrorName` parameter.</param>
  /// <param name="errorText">The `ErrorText` parameter.</param>
  /// <param name="clearedOnUpdate">The `ClearedOnUpdate` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlvalidationerrors.add?view=office-pia"/>
  public void Add(CustomXMLNode node, string errorName, string errorText, bool clearedOnUpdate) { throw new NotImplementedException(); }

  #endregion methods
}

