namespace DocumentModel.Math;

/// <summary>
/// Accent.
/// </summary>
public interface IAccent // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Accent Properties.
  /// </summary>
  public DocumentModel.Math.IAccentProperties? AccentProperties { get ; set; }
  
  /// <summary>
  /// Base.
  /// </summary>
  public DocumentModel.Math.IBase? Base { get ; set; }
  
}
