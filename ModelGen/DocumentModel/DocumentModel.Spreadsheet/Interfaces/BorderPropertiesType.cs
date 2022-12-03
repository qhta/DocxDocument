namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the BorderPropertiesType Class.
/// </summary>
public interface BorderPropertiesType // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Line Style
  /// </summary>
  public BorderStyleKind? Style { get ; set; }
  
  /// <summary>
  /// Color.
  /// </summary>
  public ColorType? Color { get ; set; }
  
}
