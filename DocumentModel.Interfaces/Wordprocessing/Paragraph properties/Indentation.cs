namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the Indentation Class.
/// </summary>
public interface Indentation:
{
  /// <summary>
  ///   Left Indentation
  /// </summary>
  public string? Left { get; set; }
  /// <summary>
  ///   start
  /// </summary>
  public string? Start { get; set; }
  /// <summary>
  ///   Left Indentation in Character Units
  /// </summary>
  public Int32? LeftChars { get; set; }
  /// <summary>
  ///   startChars
  /// </summary>
  public Int32? StartCharacters { get; set; }
  /// <summary>
  ///   Right Indentation
  /// </summary>
  public string? Right { get; set; }
  /// <summary>
  ///   end
  /// </summary>
  public string? End { get; set; }
  /// <summary>
  ///   Right Indentation in Character Units
  /// </summary>
  public Int32? RightChars { get; set; }
  /// <summary>
  ///   endChars
  /// </summary>
  public Int32? EndCharacters { get; set; }
  /// <summary>
  ///   Indentation Removed from First Line
  /// </summary>
  public string? Hanging { get; set; }
  /// <summary>
  ///   Indentation Removed From First Line in Character Units
  /// </summary>
  public Int32? HangingChars { get; set; }
  /// <summary>
  ///   Additional First Line Indentation
  /// </summary>
  public string? FirstLine { get; set; }
  /// <summary>
  ///   Additional First Line Indentation in Character Units
  /// </summary>
  public Int32? FirstLineChars { get; set; }
}