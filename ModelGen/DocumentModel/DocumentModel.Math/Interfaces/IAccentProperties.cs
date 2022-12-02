namespace DocumentModel.Math;

/// <summary>
/// Accent Properties.
/// </summary>
public interface IAccentProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Accent Character.
  /// </summary>
  public String? AccentChar { get ; set; }
  
  /// <summary>
  /// Control Properties.
  /// </summary>
  public IControlProperties? ControlProperties { get ; set; }
  
}
