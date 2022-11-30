namespace DocumentModel.Math;

/// <summary>
/// Accent Properties.
/// </summary>
public interface IAccentProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Accent Character.
  /// </summary>
  public System.String? AccentChar { get ; set; }
  
  /// <summary>
  /// Control Properties.
  /// </summary>
  public DocumentModel.Math.IControlProperties? ControlProperties { get ; set; }
  
}
