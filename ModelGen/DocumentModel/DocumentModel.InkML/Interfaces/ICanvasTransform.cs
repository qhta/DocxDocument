namespace DocumentModel.InkML;

/// <summary>
/// Defines the CanvasTransform Class.
/// </summary>
public interface ICanvasTransform // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// invertible
  /// </summary>
  public Boolean? Invertible { get ; set; }
  
}
