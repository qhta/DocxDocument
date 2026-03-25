
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents up bars in a chart.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoupbars?view=office-pia"/>
public partial interface IMsoUpBars: InteropObject
{
  /// <summary>
  /// Selects the up bars.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoupbars.select?view=office-pia"/>
  public object Select();
  /// <summary>
  /// Deletes the up bars.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoupbars.delete?view=office-pia"/>
  public object Delete();
}

