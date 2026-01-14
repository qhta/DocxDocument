namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies the bracket style for two lines in one text.
/// </summary>
public enum TwoLinesInOneBracketKind
{
  /// <summary>No brackets</summary>
  None = 0,
  /// <summary>Parentheses ()</summary>
  Parentheses = 1,
  /// <summary>Square brackets []</summary>
  SquareBrackets = 2,
  /// <summary>Angle brackets &lt;&gt;</summary>
  AngleBrackets = 3,
  /// <summary>Curly brackets {}</summary>
  CurlyBrackets = 4
}