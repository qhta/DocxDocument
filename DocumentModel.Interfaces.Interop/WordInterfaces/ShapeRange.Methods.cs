namespace DocumentModel.Interop;

public partial interface ShapeRange
{
  /// <summary>
  /// Aligns the shapes in the range according to the specified alignment command.
  /// </summary>
  /// <param name="Align">The alignment command to apply.</param>
  /// <param name="RelativeTo">Specifies whether to align relative to the margin, page, or selected shapes.</param>
  public void Align(Core.MsoAlignCmd Align, int RelativeTo);
}
