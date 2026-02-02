namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies how a list level should be positioned.
/// </summary>
[OpenXmlNotMapped]
public enum ListLevelPositionKind
{
  /// <summary>Position relative to left margin</summary>
  Left = 0,
  /// <summary>Position centered</summary>
  Center = 1,
  /// <summary>Position relative to right margin</summary>
  Right = 2
}