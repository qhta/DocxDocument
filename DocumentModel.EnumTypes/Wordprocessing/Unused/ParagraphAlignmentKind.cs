namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies paragraph alignment.
/// </summary>
[OpenXmlNotMapped]
public enum ParagraphAlignmentKind
{
  /// <summary>Left-aligned</summary>
  Left = 0,
  /// <summary>Center-aligned</summary>
  Center = 1,
  /// <summary>Right-aligned</summary>
  Right = 2,
  /// <summary>Fully justified</summary>
  Justify = 3,
  /// <summary>Distributed (similar to justify but with different character spacing)</summary>
  Distribute = 4,
  /// <summary>Thai distributed</summary>
  ThaiDistribute = 5
}