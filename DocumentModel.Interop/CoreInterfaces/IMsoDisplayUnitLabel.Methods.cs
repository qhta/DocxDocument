
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a display unit label.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel?view=office-pia
/// </remarks>
public partial interface IMsoDisplayUnitLabel
{
  /// <summary>
  /// Deletes the display unit label.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.delete?view=office-pia
  /// </remarks>
  public new object Delete();
  /// <summary>
  /// Selects the display unit label.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.select?view=office-pia
  /// </remarks>
  public new object Select();
}
