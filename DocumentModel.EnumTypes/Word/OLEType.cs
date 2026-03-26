namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the type of an OLE object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdoletype?view=office-pia` for Office interop details.
/// </remarks>
public enum OLEType
{
  /// <summary>
  /// Linked OLE object.
  /// </summary>
  Link = 0,
  /// <summary>
  /// Embedded OLE object.
  /// </summary>
  Embed = 1,
  /// <summary>
  /// OLE control.
  /// </summary>
  Control = 2
}
