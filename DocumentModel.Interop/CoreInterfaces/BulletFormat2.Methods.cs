
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents bullet formatting.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.bulletformat2?view=office-pia
/// </remarks>
public partial interface BulletFormat2
{
  /// <summary>
  /// Sets the picture used for bullet formatting.
  /// </summary>
  /// <param name="FileName">The `FileName` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.bulletformat2.picture?view=office-pia
  /// </remarks>
  public void Picture(string FileName);
}
