
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a chart axis title.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxistitle?view=office-pia
/// </remarks>
public partial interface IMsoAxisTitle
{
  /// <summary>
  /// Deletes the axis title.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxistitle.delete?view=office-pia
  /// </remarks>
  public new object Delete();
  /// <summary>
  /// Selects the axis title.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxistitle.select?view=office-pia
  /// </remarks>
  public new object Select();
}
