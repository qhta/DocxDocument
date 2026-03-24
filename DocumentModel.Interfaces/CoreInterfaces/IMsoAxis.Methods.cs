
namespace DocumentModel.Interfaces;

/// <summary>
/// Represents a chart axis.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis?view=office-pia"/>
public partial interface IMsoAxis
{
  /// <summary>
  /// Deletes the axis.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.delete?view=office-pia"/>
  public object Delete();
  /// <summary>
  /// Selects the axis.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxis.select?view=office-pia"/>
  public object Select();
}

