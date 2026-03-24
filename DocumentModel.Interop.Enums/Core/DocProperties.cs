
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.docproperties?view=office-pia` for Office interop details.
/// </remarks>
public enum DocProperties
{
  /// <summary>
  /// Integer type
  /// </summary>
  Number = 1,
  /// <summary>
  /// Boolean type
  /// </summary>
  Boolean,
  /// <summary>
  /// Date-time type
  /// </summary>
  Date,
  /// <summary>
  /// String type
  /// </summary>
  String,
  /// <summary>
  /// Float type
  /// </summary>
  Float
}
