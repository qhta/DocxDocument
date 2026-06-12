namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents special formatting applied to specified areas of a table when the selected table is formatted with a specified table style.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conditionalstyle?view=word-pia"/>
public interface IConditionalStyle : IModelObject
{
  /// <summary>
  /// Gets the shading formatting for the conditional style.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conditionalstyle.shading?view=word-pia"/>
  public DMD.IShading Shading { get; }
  /// <summary>
  /// Gets or sets the border formatting for the conditional style.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conditionalstyle.borders?view=word-pia"/>
  public IBorders Borders { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the bottom cell padding, in points, for the conditional style.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conditionalstyle.bottompadding?view=word-pia"/>
  public float BottomPadding { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the top cell padding, in points, for the conditional style.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conditionalstyle.toppadding?view=word-pia"/>
  public float TopPadding { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the left cell padding, in points, for the conditional style.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conditionalstyle.leftpadding?view=word-pia"/>
  public float LeftPadding { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the right cell padding, in points, for the conditional style.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conditionalstyle.rightpadding?view=word-pia"/>
  public float RightPadding { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the paragraph formatting for the conditional style.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conditionalstyle.paragraphformat?view=word-pia"/>
  public IParagraphFormat ParagraphFormat { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the font formatting for the conditional style.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conditionalstyle.font?view=word-pia"/>
  public ITextFormat TextFormat { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

}
