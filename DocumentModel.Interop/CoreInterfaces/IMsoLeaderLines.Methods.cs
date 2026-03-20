
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents leader lines in a chart.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoleaderlines?view=office-pia
/// </remarks>
public partial interface IMsoLeaderLines
{
  /// <summary>
  /// Selects the leader lines.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoleaderlines.select?view=office-pia
  /// </remarks>
  public void Select();
  /// <summary>
  /// Deletes the leader lines.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoleaderlines.delete?view=office-pia
  /// </remarks>
  public void Delete();
}
