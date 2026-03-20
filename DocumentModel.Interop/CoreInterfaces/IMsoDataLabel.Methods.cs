
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a data label.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel?view=office-pia
/// </remarks>
public partial interface IMsoDataLabel
{
  /// <summary>
  /// Selects the data label.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.select?view=office-pia
  /// </remarks>
  public object Select();
  /// <summary>
  /// Deletes the data label.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodatalabel.delete?view=office-pia
  /// </remarks>
  public object Delete();
}
