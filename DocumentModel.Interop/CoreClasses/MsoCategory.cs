
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocategory?view=office-pia"/>
public partial class MsoCategory
{
  /// <summary>
  /// Gets or sets the `Name` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocategory.name?view=office-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets or sets the `IsFiltered` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocategory.isfiltered?view=office-pia"/>
  public bool IsFiltered { get; set; }
}


