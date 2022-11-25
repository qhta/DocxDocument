namespace DocumentModel.InkML;

/// <summary>
/// Defines the Table Class.
/// </summary>
public interface ITable // : DocumentModel.ITypedOpenXmlLeafTextElement
{
  /// <summary>
  /// id
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// apply
  /// </summary>
  public DocumentModel.InkML.TableApplyKind? Apply { get ; set; }
  
  /// <summary>
  /// interpolation
  /// </summary>
  public DocumentModel.InkML.TableInterpolationKind? Interpolation { get ; set; }
  
}
