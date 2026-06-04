namespace DocumentModel.Interop.Word;

/// <summary>
/// This enumeration has been deprecated and should not be used.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdsubscriberformats?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdSubscriberFormats")]
public enum SubscriberFormats
{
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdSubscriberBestFormat")]
  BestFormat = 0,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdSubscriberRTF")]
  RTF = 1,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdSubscriberText")]
  Text = 2,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdSubscriberPict")]
  Pict = 4
}
