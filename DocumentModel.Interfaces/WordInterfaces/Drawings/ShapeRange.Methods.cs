namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange?view=word-pia"/>
public partial interface ShapeRange: InteropObject
{
  /// <summary>
  /// Aligns the shapes in the range according to the specified alignment command.
  /// </summary>
  /// <param name="Align">The alignment command to apply.</param>
  /// <param name="RelativeTo">Specifies whether to align relative to the margin, page, or selected shapes.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.shaperange.align?view=word-pia"/>
  public void Align(Core.MsoAlignCmd Align, int RelativeTo);
}
