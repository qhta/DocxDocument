namespace DocumentModel.Drawing;

/// <summary>
/// Defines the EffectContainerType Class.
/// </summary>
public interface IEffectContainerType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Effect Container Type
  /// </summary>
  public DocumentModel.Drawing.EffectContainerKind? Type { get ; set; }
  
  /// <summary>
  /// Name
  /// </summary>
  public System.String? Name { get ; set; }
  
}
