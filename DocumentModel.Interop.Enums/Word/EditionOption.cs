namespace DocumentModel.Interop.Word;

/// <summary>
/// This enumeration has been deprecated and should not be used.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdeditionoption?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdEditionOption))]
public enum EditionOption
{
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdEditionOption.wdCancelPublisher))]
  CancelPublisher = 0,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdEditionOption.wdSendPublisher))]
  SendPublisher = 1,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdEditionOption.wdSelectPublisher))]
  SelectPublisher = 2,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdEditionOption.wdAutomaticUpdate))]
  AutomaticUpdate = 3,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdEditionOption.wdManualUpdate))]
  ManualUpdate = 4,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdEditionOption.wdChangeAttributes))]
  ChangeAttributes = 5,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdEditionOption.wdUpdateSubscriber))]
  UpdateSubscriber = 6,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdEditionOption.wdOpenSource))]
  OpenSource = 7
}
