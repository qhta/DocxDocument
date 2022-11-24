namespace DocumentModel.EMMA;

/// <summary>
/// Defines the Model Class.
/// </summary>
public interface IModel // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// ref
  /// </summary>
  public String? Reference { get ; set; }
  
}
