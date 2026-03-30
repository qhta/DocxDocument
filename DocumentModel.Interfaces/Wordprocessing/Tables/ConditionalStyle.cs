namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents special formatting applied to specified areas of a table when the selected table is formatted with a specified table style.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conditionalstyle?view=word-pia"/>
public interface IConditionalStyle : IModelObject
{
  /// <summary>
  /// Gets the shading formatting for the conditional style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conditionalstyle.shading?view=word-pia"/>
  public Drw.IShading Shading { get; }
  /// <summary>
  /// Gets or sets the border formatting for the conditional style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conditionalstyle.borders?view=word-pia"/>
  public IBorders Borders { get; set; }
  /// <summary>
  /// Gets or sets the bottom cell padding, in points, for the conditional style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conditionalstyle.bottompadding?view=word-pia"/>
  public float BottomPadding { get; set; }
  /// <summary>
  /// Gets or sets the top cell padding, in points, for the conditional style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conditionalstyle.toppadding?view=word-pia"/>
  public float TopPadding { get; set; }
  /// <summary>
  /// Gets or sets the left cell padding, in points, for the conditional style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conditionalstyle.leftpadding?view=word-pia"/>
  public float LeftPadding { get; set; }
  /// <summary>
  /// Gets or sets the right cell padding, in points, for the conditional style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conditionalstyle.rightpadding?view=word-pia"/>
  public float RightPadding { get; set; }
  /// <summary>
  /// Gets or sets the paragraph formatting for the conditional style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conditionalstyle.paragraphformat?view=word-pia"/>
  public IParagraphFormat ParagraphFormat { get; set; }
  /// <summary>
  /// Gets or sets the font formatting for the conditional style.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conditionalstyle.font?view=word-pia"/>
  public IFont Font { get; set; }

}
