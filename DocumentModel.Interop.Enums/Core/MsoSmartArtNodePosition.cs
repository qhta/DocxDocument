namespace DocumentModel.Interop.Core;

/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msosmartartnodeposition?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoSmartArtNodePosition")]
public enum SmartArtNodePosition
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoSmartArtNodeDefault")]
  Default = 1,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoSmartArtNodeAfter")]
  After,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoSmartArtNodeBefore")]
  Before,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoSmartArtNodeAbove")]
  Above,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoSmartArtNodeBelow")]
  Below
}
