namespace DocumentModel.InkML;

/// <summary>
/// Defines the Table Class.
/// </summary>
public interface ITable // : DocumentModel.ITypedOpenXmlLeafTextElement
{
  /// <summary>
  /// id
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// apply
  /// </summary>
  public TableApplyValues? Apply { get ; set; }
  
  /// <summary>
  /// interpolation
  /// </summary>
  public TableInterpolationValues? Interpolation { get ; set; }
  
}
