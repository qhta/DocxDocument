namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Indentation Class.
/// </summary>
public class Indentation: ModelElement
{
  /// <summary>
  ///   Left Indentation
  /// </summary>
  public string? Left { get; set; }

  /// <summary>
  ///   start, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Start { get; set; }

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
  public string? Right { get; set; }

  /// <summary>
  ///   end, this property is only available in Office 2010 and later.
  /// </summary>
  public string? End { get; set; }

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