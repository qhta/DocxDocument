
namespace DocumentModel.Interfaces;

/// <summary>
/// Represents the plot area of a chart.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoplotarea?view=office-pia"/>
public partial interface IMsoPlotArea
{
  /// <summary>
  /// Selects the plot area.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoplotarea.select?view=office-pia"/>
  public object Select();
  /// <summary>
  /// Clears formatting from the plot area.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoplotarea.clearformats?view=office-pia"/>
  public object ClearFormats();
}

