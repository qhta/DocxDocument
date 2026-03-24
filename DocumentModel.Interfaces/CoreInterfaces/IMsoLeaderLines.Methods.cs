
namespace DocumentModel.Interfaces;

/// <summary>
/// Represents leader lines in a chart.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoleaderlines?view=office-pia"/>
public partial interface IMsoLeaderLines
{
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
}

