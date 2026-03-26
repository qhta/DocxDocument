namespace DocumentModel.Interop.Word;

/// <summary>
/// This enumeration groups together constants used with various Microsoft Word methods.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdconstants?view=office-pia` for Office interop details.
/// </remarks>
public enum Constants
{
  /// <summary>
  /// Represents the Auto value for the specified setting.
  /// </summary>
  AutoPosition = 0,
  /// <summary>
  /// Represents the first item in a collection.
  /// </summary>
  First = 1,
  /// <summary>
  /// Toggles a property's value.
  /// </summary>
  Toggle = 9999998,
  /// <summary>
  /// Represents an undefined value. wdForward 1073741823Indicates that selection will be extended forward using the
  /// MoveStartUntil or MoveStartWhile method of the Range or Selection object. wdCreatorCode1297307460Represents
  /// the creator code for objects created by Microsoft Word.
  /// </summary>
  Undefined = 9999999,
  /// <summary>
  /// This enumeration groups together constants used with various Microsoft Word methods.
  /// </summary>
  Forward = 1073741823,
  /// <summary>
  /// This enumeration groups together constants used with various Microsoft Word methods.
  /// </summary>
  CreatorCode = 1297307460,
  /// <summary>
  /// This enumeration groups together constants used with various Microsoft Word methods.
  /// </summary>
  Backward = -1073741823
}
