
namespace DocumentModel.Drawings;

/// <summary>
/// Represents bullet formatting.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.bulletformat2?view=office-pia"/>
public partial interface BulletFormat2: InteropObject
{
  /// <summary>
  /// Sets the picture used for bullet formatting.
  /// </summary>
  /// <param name="FileName">The `FileName` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.bulletformat2.picture?view=office-pia"/>
  public void Picture(string FileName);
}

