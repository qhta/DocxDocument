namespace DocumentModel.EMMA;

/// <summary>
/// Defines the Model Class.
/// </summary>
public interface IModel // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// ref
  /// </summary>
  public System.String? Reference { get ; set; }
  
}
