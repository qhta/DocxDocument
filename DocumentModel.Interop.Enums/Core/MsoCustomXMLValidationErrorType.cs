namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates how validation errors will be cleared or generated.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocustomxmlvalidationerrortype?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoCustomXMLValidationErrorType
{
  /// <summary>
  /// Indicates how validation errors will be cleared or generated.
  /// </summary>
  SchemaGenerated,
  /// <summary>
  /// Indicates how validation errors will be cleared or generated.
  /// </summary>
  AutomaticallyCleared,
  /// <summary>
  /// Specifies that the error will not be cleared until the Delete() method is called.
  /// </summary>
  Manual
}
