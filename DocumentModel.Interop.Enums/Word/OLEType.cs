namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of an OLE object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdoletype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdOLEType")]
public enum OLEType
{
  /// <summary>
  /// Linked OLE object.
  /// </summary>
  [WordInteropEnumValue("wdOLELink")]
  Link = 0,
  /// <summary>
  /// Embedded OLE object.
  /// </summary>
  [WordInteropEnumValue("wdOLEEmbed")]
  Embed = 1,
  /// <summary>
  /// OLE control.
  /// </summary>
  [WordInteropEnumValue("wdOLEControl")]
  Control = 2
}
