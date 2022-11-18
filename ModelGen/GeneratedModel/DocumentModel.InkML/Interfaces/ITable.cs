namespace DocumentModel.InkML;

/// <summary>
/// Defines the Table Class.
/// </summary>
public interface ITable // : DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement
{
  /// <summary>
  /// id
  /// </summary>
  public string? Id { get ; set; }
  
  /// <summary>
  /// apply
  /// </summary>
  public TableApply? Apply { get ; set; }
  
  /// <summary>
  /// interpolation
  /// </summary>
  public TableInterpolation? Interpolation { get ; set; }
  
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text { get ; set; }
  
}
