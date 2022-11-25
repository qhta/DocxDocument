namespace DocumentModel.InkML;

/// <summary>
/// Defines the CanvasTransform Class.
/// </summary>
public interface ICanvasTransform // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// invertible
  /// </summary>
  public System.Boolean? Invertible { get ; set; }
  
}
