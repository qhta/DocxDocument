namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates how validation errors will be cleared or generated.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocustomxmlvalidationerrortype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoCustomXMLValidationErrorType")]
public enum CustomXMLValidationErrorType
{
  /// <summary>
  /// Specifies that where there is a non-empty schema collection available for the custom XML part and validation
  /// is in effect, any changes to the part will cause validation errors.
  /// </summary>
  [OfficeInteropEnumValue("msoCustomXMLValidationErrorSchemaGenerated")]
  SchemaGenerated,
  /// <summary>
  /// Specifies that the error will clear itself whenever any change is made to the node it is bound to.
  /// </summary>
  [OfficeInteropEnumValue("msoCustomXMLValidationErrorAutomaticallyCleared")]
  AutomaticallyCleared,
  /// <summary>
  /// Specifies that the error will not be cleared until the Delete() method is called.
  /// </summary>
  [OfficeInteropEnumValue("msoCustomXMLValidationErrorManual")]
  Manual
}
