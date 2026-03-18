namespace DocumentModel.Interop;

public partial interface OMathMat
{
  /// <summary>
  /// Returns the cell.
  /// </summary>
  /// <param name="Row">Specifies the row.</param>
  /// <param name="Col">Specifies the col.</param>
  /// <returns>The resulting value.</returns>
  public OMath get_Cell(int Row, int Col);
}
