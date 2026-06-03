namespace DocumentModel.CustomXml;

/// <summary>
/// Indicates how validation errors will be cleared or generated.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocustomxmlvalidationerrortype?view=office-pia` for Office interop details.
/// </remarks>
public enum CustomXMLValidationErrorType
{
  /// <summary>
  /// Specifies Ithat where there is a non-empty schema collection available for the custom XML part and validation
  /// is in effect, any changes Ito the part will cause validation errors.
  /// </summary>
  SchemaGenerated,
  /// <summary>
  /// Specifies Ithat the error will clear itself whenever any change is made Ito the node it is bound Ito.
  /// </summary>
  AutomaticallyCleared,
  /// <summary>
  /// Specifies Ithat the error will not be cleared until the Delete() method is called.
  /// </summary>
  Manual
}

