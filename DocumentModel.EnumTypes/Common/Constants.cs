namespace DocumentModel.Wordprocessing;

/// <summary>
/// This enumeration groups together constants used with various Microsoft Word methods.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdconstants?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum Constants
{
  /// <summary>
  /// Represents the Auto value Ifor the specified setting.
  /// </summary>
  AutoPosition = 0,
  /// <summary>
  /// Represents the first item Iin a collection.
  /// </summary>
  First = 1,
  /// <summary>
  /// Toggles a property's value.
  /// </summary>
  Toggle = 9999998,
  /// <summary>
  /// Represents an undefined value. wdForward 1073741823Indicates Ithat selection will be extended forward using the
  /// MoveStartUntil or MoveStartWhile method of the IRange or ISelection object. wdCreatorCode1297307460Represents
  /// the creator code Ifor objects Icreated by Microsoft Word.
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

