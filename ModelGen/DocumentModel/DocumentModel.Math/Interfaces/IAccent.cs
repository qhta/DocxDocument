namespace DocumentModel.Math;

/// <summary>
/// Accent.
/// </summary>
public interface IAccent // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Accent Properties.
  /// </summary>
  public IAccentProperties? AccentProperties { get ; set; }
  
  /// <summary>
  /// Base.
  /// </summary>
  public IBase? Base { get ; set; }
  
}
