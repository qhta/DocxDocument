namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents line numbers in the left margin or to the left of each newspaper-style column.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.linenumbering?view=word-pia"/>
public interface LineNumbering : InteropObject
{
  /// <summary>
  /// The restart mode.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.linenumbering.restartmode?view=word-pia"/>
  public WdNumberingRule RestartMode { get; set; }
  /// <summary>
  /// The starting number.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.linenumbering.startingnumber?view=word-pia"/>
  public int StartingNumber { get; set; }
  /// <summary>
  /// The distance from text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.linenumbering.distancefromtext?view=word-pia"/>
  public float DistanceFromText { get; set; }
  /// <summary>
  /// The count by.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.linenumbering.countby?view=word-pia"/>
  public int CountBy { get; set; }
  /// <summary>
  /// The active.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.linenumbering.active?view=word-pia"/>
  public int Active { get; set; }

}
