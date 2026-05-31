    namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the data type for a document property.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodocproperties?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoDocProperties
{
  /// <summary>
  /// Integer value.
  /// </summary>
  Number = 1,
  /// <summary>
  /// Boolean value.
  /// </summary>
  Boolean,
  /// <summary>
  /// Date value.
  /// </summary>
  Date,
  /// <summary>
  /// String value.
  /// </summary>
  String,
  /// <summary>
  /// Floating point value.
  /// </summary>
  Float
}
