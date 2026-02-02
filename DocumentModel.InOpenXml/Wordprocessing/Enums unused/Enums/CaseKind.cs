namespace DocumentModel.Wordprocessing;

/// <summary>
/// Text case types.
/// </summary>
[OpenXmlNotMapped]
public enum CaseKind
{
  /// <summary>Mixed case</summary>
  Mixed,
  /// <summary>Uppercase</summary>
  Upper,
  /// <summary>Lowercase</summary>
  Lower,
  /// <summary>Title case</summary>
  Title,
  /// <summary>Toggle case</summary>
  Toggle
}