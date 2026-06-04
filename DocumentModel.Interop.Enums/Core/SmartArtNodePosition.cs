namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msosmartartnodeposition?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoSmartArtNodePosition")]
public enum SmartArtNodePosition
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoSmartArtNodeDefault")]
  Default = 1,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoSmartArtNodeAfter")]
  After,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoSmartArtNodeBefore")]
  Before,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoSmartArtNodeAbove")]
  Above,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoSmartArtNodeBelow")]
  Below
}
