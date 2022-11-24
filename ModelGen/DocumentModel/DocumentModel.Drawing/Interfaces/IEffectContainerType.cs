namespace DocumentModel.Drawing;

/// <summary>
/// Defines the EffectContainerType Class.
/// </summary>
public interface IEffectContainerType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Effect Container Type
  /// </summary>
  public EffectContainerValues? Type { get ; set; }
  
  /// <summary>
  /// Name
  /// </summary>
  public String? Name { get ; set; }
  
}
