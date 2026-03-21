namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of TextColumn objects that represent all the columns of text in a document or a section of a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textcolumns?view=word-pia"/>
public partial interface TextColumns : InteropObject, InteropCollection<TextColumn>
{
  /// <summary>
  /// The evenly spaced.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textcolumns.evenlyspaced?view=word-pia"/>
  public int EvenlySpaced { get; set; }

  /// <summary>
  /// The line between.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textcolumns.linebetween?view=word-pia"/>
  public int LineBetween { get; set; }

  /// <summary>
  /// The width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textcolumns.width?view=word-pia"/>
  public float Width { get; set; }

  /// <summary>
  /// The spacing.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textcolumns.spacing?view=word-pia"/>
  public float Spacing { get; set; }

  /// <summary>
  /// The flow direction.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textcolumns.flowdirection?view=word-pia"/>
  public WdFlowDirection FlowDirection { get; set; }
}
