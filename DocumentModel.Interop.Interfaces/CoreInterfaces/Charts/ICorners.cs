
namespace DocumentModel.Interop.Core;	
/// <summary>
/// Represents chart corners.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocorners?view=office-pia"/>
public interface ICorners
{
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocorners.name?view=office-pia"/>
  public string Name { get; }	

  #region methods	
/// <summary>
  /// Selects the chart corners.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocorners.select?view=office-pia"/>
  public object Select();	
  #endregion methods
}	

