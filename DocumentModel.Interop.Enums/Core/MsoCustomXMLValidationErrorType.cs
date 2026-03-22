namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates how validation errors will be cleared or generated.
/// </summary>
public enum MsoCustomXMLValidationErrorType
{
  /// <summary>
  /// Indicates how validation errors will be cleared or generated.
  /// </summary>
  msoCustomXMLValidationErrorSchemaGenerated,
  /// <summary>
  /// Indicates how validation errors will be cleared or generated.
  /// </summary>
  msoCustomXMLValidationErrorAutomaticallyCleared,
  /// <summary>
  /// Specifies that the error will not be cleared until the Delete() method is called.
  /// </summary>
  msoCustomXMLValidationErrorManual
}
