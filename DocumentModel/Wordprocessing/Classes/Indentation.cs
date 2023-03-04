namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the Indentation Class.
/// </summary>
public class Indentation
{
  /// <summary>
  ///   Left Indentation
  /// </summary>
  public String? Left { get; set; }

  /// <summary>
  ///   start, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Start { get; set; }

  /// <summary>
  ///   Left Indentation in Character Units
  /// </summary>
  public Int32? LeftChars { get; set; }

  /// <summary>
  ///   startChars, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? StartCharacters { get; set; }

  /// <summary>
  ///   Right Indentation
  /// </summary>
  public String? Right { get; set; }

  /// <summary>
  ///   end, this property is only available in Office 2010 and later.
  /// </summary>
  public String? End { get; set; }

  /// <summary>
  ///   Right Indentation in Character Units
  /// </summary>
  public Int32? RightChars { get; set; }

  /// <summary>
  ///   endChars, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? EndCharacters { get; set; }

  /// <summary>
  ///   Indentation Removed from First Line
  /// </summary>
  public String? Hanging { get; set; }

  /// <summary>
  ///   Indentation Removed From First Line in Character Units
  /// </summary>
  public Int32? HangingChars { get; set; }

  /// <summary>
  ///   Additional First Line Indentation
  /// </summary>
  public String? FirstLine { get; set; }

  /// <summary>
  ///   Additional First Line Indentation in Character Units
  /// </summary>
  public Int32? FirstLineChars { get; set; }
}