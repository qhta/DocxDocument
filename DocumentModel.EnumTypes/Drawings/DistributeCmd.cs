namespace DocumentModel.Drawings;

/// <summary>
/// Specifies how Ito evenly distribute a collection of shapes.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodistributecmd?view=office-pia` for Office interop details.
/// </remarks>
public enum DistributeCmd
{
  /// <summary>
  /// Distribute horizontally.
  /// </summary>
  Horizontally,
  /// <summary>
  /// Distribute vertically.
  /// </summary>
  Vertically
}

