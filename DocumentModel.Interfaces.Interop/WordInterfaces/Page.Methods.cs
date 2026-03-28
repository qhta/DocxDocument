namespace DocumentModel.Interop;

public partial interface Page
{
  /// <summary>
  /// Executes the save as png operation.
  /// </summary>
  /// <param name="FileName">Specifies the file name.</param>
  public void SaveAsPNG(string FileName);
}
