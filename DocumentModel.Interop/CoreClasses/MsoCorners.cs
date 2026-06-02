
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents chart corners.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocorners?view=office-pia"/>
public partial class MsoCorners
{
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocorners.name?view=office-pia"/>
  public string Name { get; }


  #region methods

/// <summary>
  /// Selects the chart corners.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocorners.select?view=office-pia"/>
  public object Select() { throw new NotImplementedException(); }

  #endregion methods
}


