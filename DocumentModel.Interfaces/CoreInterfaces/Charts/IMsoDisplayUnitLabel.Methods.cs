
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Represents a display unit label.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel?view=office-pia"/>
public partial interface IMsoDisplayUnitLabel: InteropObject
{
  /// <summary>
  /// Deletes the display unit label.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.delete?view=office-pia"/>
  public new object Delete();
  /// <summary>
  /// Selects the display unit label.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodisplayunitlabel.select?view=office-pia"/>
  public new object Select();
}

