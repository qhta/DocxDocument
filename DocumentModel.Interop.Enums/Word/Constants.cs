namespace DocumentModel.Interop.Word;

/// <summary>
/// This enumeration groups together constants used with various Microsoft Word methods.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdconstants?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdConstants")]
public enum Constants
{
  /// <summary>
  /// Represents the Auto value for the specified setting.
  /// </summary>
  [WordInteropEnumValue("wdAutoPosition")]
  AutoPosition = 0,
  /// <summary>
  /// Represents the first item in a collection.
  /// </summary>
  [WordInteropEnumValue("wdFirst")]
  First = 1,
  /// <summary>
  /// Toggles a property's value.
  /// </summary>
  [WordInteropEnumValue("wdToggle")]
  Toggle = 9999998,
  /// <summary>
  /// Represents an undefined value. wdForward 1073741823Indicates that selection will be extended forward using the
  /// MoveStartUntil or MoveStartWhile method of the Range or Selection object. wdCreatorCode1297307460Represents
  /// the creator code for objects created by Microsoft Word.
  /// </summary>
  [WordInteropEnumValue("wdUndefined")]
  Undefined = 9999999,
  /// <summary>
  /// This enumeration groups together constants used with various Microsoft Word methods.
  /// </summary>
  [WordInteropEnumValue("wdForward")]
  Forward = 1073741823,
  /// <summary>
  /// This enumeration groups together constants used with various Microsoft Word methods.
  /// </summary>
  [WordInteropEnumValue("wdCreatorCode")]
  CreatorCode = 1297307460,
  /// <summary>
  /// This enumeration groups together constants used with various Microsoft Word methods.
  /// </summary>
  [WordInteropEnumValue("wdBackward")]
  Backward = -1073741823
}
