namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents line numbers in the left margin or to the left of each newspaper-style column.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.linenumbering?view=word-pia"/>
public interface ILineNumbering : IModelObject
{
  /// <summary>
  /// Returns or sets when line numbering restarts.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.linenumbering.restartmode?view=word-pia"/>
  public NumberingRule RestartMode { get; set; }
  /// <summary>
  /// Returns or sets the starting line number.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.linenumbering.startingnumber?view=word-pia"/>
  public int StartingNumber { get; set; }
  /// <summary>
  /// Returns or sets the distance between line numbers and document text, in points.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.linenumbering.distancefromtext?view=word-pia"/>
  public float DistanceFromText { get; set; }
  /// <summary>
  /// Returns or sets the line numbering interval.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.linenumbering.countby?view=word-pia"/>
  public int CountBy { get; set; }
  /// <summary>
  /// Returns or sets whether line numbering is active.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.linenumbering.active?view=word-pia"/>
  public int Active { get; set; }

}
