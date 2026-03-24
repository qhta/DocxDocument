namespace DocumentModel.Interop.Word;

/// <summary>
/// This enumeration groups together constants used with various Microsoft Word methods.
/// </summary>
public enum WdConstants
{
  /// <summary>
  /// This enumeration groups together constants used with various Microsoft Word methods.
  /// </summary>
  AutoPosition = unchecked((int)0),
  /// <summary>
  /// Represents the first item in a collection.
  /// </summary>
  First = unchecked((int)1),
  /// <summary>
  /// Toggles a property's value.
  /// </summary>
  Toggle = unchecked((int)9999998),
  /// <summary>
  /// Represents an undefined value. wdForward 1073741823Indicates that selection will be extended forward using the
  /// MoveStartUntil or MoveStartWhile method of the Range or Selection object. wdCreatorCode1297307460Represents
  /// the creator code for objects created by Microsoft Word.
  /// </summary>
  Undefined = unchecked((int)9999999),
  /// <summary>
  /// This enumeration groups together constants used with various Microsoft Word methods.
  /// </summary>
  Forward = unchecked((int)1073741823),
  /// <summary>
  /// This enumeration groups together constants used with various Microsoft Word methods.
  /// </summary>
  CreatorCode = unchecked((int)1297307460),
  /// <summary>
  /// This enumeration groups together constants used with various Microsoft Word methods.
  /// </summary>
  Backward = unchecked((int)-1073741823)
}
