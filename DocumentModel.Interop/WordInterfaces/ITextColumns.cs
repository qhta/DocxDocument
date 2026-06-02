namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of TextColumn objects that represent all the columns of text in a document or a section of a
/// document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textcolumns?view=word-pia"/>
public interface ITextColumns : IInteropObject, IInteropCollection<TextColumn>
{
  /// <summary>
  /// True if text columns are evenly spaced. Can be True, False, or wdUndefined.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textcolumns.evenlyspaced?view=word-pia"/>
  public int EvenlySpaced { get; set; }

  /// <summary>
  /// True if vertical lines appear between all the columns in the TextColumns collection. Can be True, False, or
  /// wdUndefined.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textcolumns.linebetween?view=word-pia"/>
  public int LineBetween { get; set; }

  /// <summary>
  /// Returns or sets the width of the specified object, in points.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textcolumns.width?view=word-pia"/>
  public float Width { get; set; }

  /// <summary>
  /// Returns or sets the spacing (in points) between columns of a TextColumns object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textcolumns.spacing?view=word-pia"/>
  public float Spacing { get; set; }

  /// <summary>
  /// Returns or sets the direction in which text flows from one text column to the next.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textcolumns.flowdirection?view=word-pia"/>
  public FlowDirection FlowDirection { get; set; }


  #region methods

/// <summary>
  /// Adds a new text column to the collection.
  /// </summary>
  /// <param name="Width">The width of the new column.</param>
  /// <param name="Spacing">The spacing between columns.</param>
  /// <param name="EvenlySpaced">true to make columns evenly spaced; otherwise, false.</param>
  /// <returns>The created <see cref="TextColumn"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textcolumns.add?view=word-pia"/>
  public TextColumn Add(object Width, object Spacing, object EvenlySpaced);

  #endregion methods
}
