
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocategory?view=office-pia
/// </remarks>
public partial interface IMsoCategory
{
  /// <summary>
  /// Gets or sets the `Name` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocategory.name?view=office-pia
  /// </remarks>
  public string Name { get; }
  /// <summary>
  /// Gets or sets the `IsFiltered` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocategory.isfiltered?view=office-pia
  /// </remarks>
  public bool IsFiltered { get; set; }
}
