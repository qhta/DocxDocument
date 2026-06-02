
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents drop lines in a chart.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodroplines?view=office-pia"/>
public partial class MsoDropLines
{
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodroplines.name?view=office-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets the `Border` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodroplines.border?view=office-pia"/>
  public IMsoBorder Border { get; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodroplines.format?view=office-pia"/>
  public MsoChartFormat Format { get; }


  #region methods

/// <summary>
  /// Selects the drop lines.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodroplines.select?view=office-pia"/>
  public void Select() { throw new NotImplementedException(); }
  /// <summary>
  /// Deletes the drop lines.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodroplines.delete?view=office-pia"/>
  public void Delete() { throw new NotImplementedException(); }

  #endregion methods
}


