namespace DocumentModel.Interop.Word;

/// <summary>
/// This enumeration has been deprecated and should not be used.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdeditionoption?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdEditionOption")]
public enum EditionOption
{
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("wdCancelPublisher")]
  CancelPublisher = 0,
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("wdSendPublisher")]
  SendPublisher = 1,
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("wdSelectPublisher")]
  SelectPublisher = 2,
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("wdAutomaticUpdate")]
  AutomaticUpdate = 3,
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("wdManualUpdate")]
  ManualUpdate = 4,
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("wdChangeAttributes")]
  ChangeAttributes = 5,
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("wdUpdateSubscriber")]
  UpdateSubscriber = 6,
  /// <summary>
  /// Not supported.
  /// </summary>
  [InteropEnumValue("wdOpenSource")]
  OpenSource = 7
}
