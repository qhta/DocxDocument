namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of version for the document checked in when using the CheckIn(Boolean, Object, Boolean)
/// method. Applies to documents stored in a SharePoint library.
/// </summary>
public enum WdCheckInVersionType
{
  /// <summary>
  /// Minor version.
  /// </summary>
  wdCheckInMinorVersion = unchecked((int)0),
  /// <summary>
  /// Major version.
  /// </summary>
  wdCheckInMajorVersion = unchecked((int)1),
  /// <summary>
  /// Overwrite current version on the server.
  /// </summary>
  wdCheckInOverwriteVersion = unchecked((int)2)
}
