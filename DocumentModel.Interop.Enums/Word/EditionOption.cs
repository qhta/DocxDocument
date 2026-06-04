namespace DocumentModel.Interop.Word;

/// <summary>
/// This enumeration has been deprecated and should not be used.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdeditionoption?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdEditionOption")]
public enum EditionOption
{
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdCancelPublisher")]
  CancelPublisher = 0,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdSendPublisher")]
  SendPublisher = 1,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdSelectPublisher")]
  SelectPublisher = 2,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdAutomaticUpdate")]
  AutomaticUpdate = 3,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdManualUpdate")]
  ManualUpdate = 4,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdChangeAttributes")]
  ChangeAttributes = 5,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdUpdateSubscriber")]
  UpdateSubscriber = 6,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdOpenSource")]
  OpenSource = 7
}
