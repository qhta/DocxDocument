
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents high-low lines in a chart.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsohilolines?view=office-pia"/>
public partial interface IMsoHiLoLines
{
  /// <summary>
  /// Selects the high-low lines.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsohilolines.select?view=office-pia"/>
  public void Select();
  /// <summary>
  /// Deletes the high-low lines.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsohilolines.delete?view=office-pia"/>
  public void Delete();
}

