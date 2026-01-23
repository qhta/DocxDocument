namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies the number style for legal or simplified legal numbering.
/// </summary>
public enum ListLevelNumberStyleKind
{
  /// <summary>Standard numbering</summary>
  Standard = 0,
  /// <summary>Legal numbering (1.1.1.)</summary>
  Legal = 1,
  /// <summary>Simplified legal numbering (1.1.a)</summary>
  SimplifiedLegal = 2
}