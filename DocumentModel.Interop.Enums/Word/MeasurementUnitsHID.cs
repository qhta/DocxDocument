namespace DocumentModel.Interop.Word;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdmeasurementunitshid?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdMeasurementUnitsHID))]
public enum MeasurementUnitsHID
{
  /// <summary>
  /// No description is available.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMeasurementUnitsHID.emptyenum))]
  emptyenum = 0
}
