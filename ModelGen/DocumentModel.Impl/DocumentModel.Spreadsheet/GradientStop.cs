namespace DocumentModel.Spreadsheet;

/// <summary>
/// Gradient Stop.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IColor))]
public class GradientStop: IGradientStop
{
  /// <summary>
  /// Gradient Stop Position
  /// </summary>
  public double? Position
  {
    get;
    set;
  }
  
  /// <summary>
  /// Color.
  /// </summary>
  public DocumentModel.Spreadsheet.IColor? Color
  {
    get;
    set;
  }
  
}
