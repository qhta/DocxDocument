
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents leader lines in a chart.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoleaderlines?view=office-pia"/>
public partial interface IMsoLeaderLines
{
  /// <summary>
  /// Gets the `Border` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoleaderlines.border?view=office-pia"/>
  public IMsoBorder Border { get; }
  /// <summary>
  /// Gets the `Format` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoleaderlines.format?view=office-pia"/>
  public MsoChartFormat Format { get; }


  #region methods

/// <summary>
  /// Selects the leader lines.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoleaderlines.select?view=office-pia"/>
  public void Select();
  /// <summary>
  /// Deletes the leader lines.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoleaderlines.delete?view=office-pia"/>
  public void Delete();

  #endregion methods
}

