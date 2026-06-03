namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents bullet formatting.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.bulletformat2?view=office-pia"/>
public interface IBulletFormat2
{


  #region methods

/// <summary>
  /// Sets the picture used for bullet formatting.
  /// </summary>
  /// <param name="fileName">The `FileName` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.bulletformat2.picture?view=office-pia"/>
  public void Picture(string fileName);

  #endregion methods
}

