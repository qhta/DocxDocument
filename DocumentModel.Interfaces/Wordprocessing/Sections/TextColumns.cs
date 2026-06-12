namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of TextColumn objects that represent all the columns of text in a document or a section of a
/// document.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textcolumns?view=word-pia"/>
public partial interface ITextColumns : IModelCollection<ITextColumn>
{
  /// <summary>
  /// True if text columns are evenly spaced. Can be True, False, or wdUndefined.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textcolumns.evenlyspaced?view=word-pia"/>
  public int EvenlySpaced { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// True if vertical lines appear between all the columns in the TextColumns collection. Can be True, False, or
  /// wdUndefined.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textcolumns.linebetween?view=word-pia"/>
  public int LineBetween { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the width of the specified object, in points.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textcolumns.width?view=word-pia"/>
  public float Width { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the spacing (in points) between columns of a TextColumns object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textcolumns.spacing?view=word-pia"/>
  public float Spacing { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Returns or sets the direction in which text flows from one text column to the next.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textcolumns.flowdirection?view=word-pia"/>
  public TableDirection FlowDirection { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}
