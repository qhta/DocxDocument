namespace DocumentModel.Interop.Word;

/// <summary>
/// This object, member, or enumeration is deprecated and is not intended to be used in your code.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdxmlselectionchangereason?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdXMLSelectionChangeReason")]
public enum XMLSelectionChangeReason
{
  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  [WordInteropEnumValue("wdXMLSelectionChangeReasonMove")]
  Move = 0,
  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  [WordInteropEnumValue("wdXMLSelectionChangeReasonInsert")]
  Insert = 1,
  /// <summary>
  /// This object, member, or enumeration is deprecated and is not intended to be used in your code.
  /// </summary>
  [WordInteropEnumValue("wdXMLSelectionChangeReasonDelete")]
  Delete = 2
}
