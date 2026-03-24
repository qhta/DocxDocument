
namespace DocumentModel.Interfaces;

/// <summary>
/// Represents a chart axis title.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxistitle?view=office-pia"/>
public partial interface IMsoAxisTitle
{
  /// <summary>
  /// Deletes the axis title.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxistitle.delete?view=office-pia"/>
  public new object Delete();
  /// <summary>
  /// Selects the axis title.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoaxistitle.select?view=office-pia"/>
  public new object Select();
}

