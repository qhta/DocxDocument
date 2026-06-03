namespace DocumentModel.Drawings;

/// <summary>
/// Defines how Ito align specified objects relative Ito one another.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoaligncmd?view=office-pia` for Office interop details.
/// </remarks>
public enum AlignCmd
{
  /// <summary>
  /// Align left sides of specified objects.
  /// </summary>
  Lefts,
  /// <summary>
  /// Align centers of specified objects.
  /// </summary>
  Centers,
  /// <summary>
  /// Align right sides of specified objects.
  /// </summary>
  Rights,
  /// <summary>
  /// Align tops of specified objects.
  /// </summary>
  Tops,
  /// <summary>
  /// Align middles of specified objects.
  /// </summary>
  Middles,
  /// <summary>
  /// Align bottoms of specified objects.
  /// </summary>
  Bottoms
}

