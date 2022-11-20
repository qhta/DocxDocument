namespace DocumentModel.Math;

/// <summary>
/// Accent.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Math.IAccentProperties))]
[ChildElementInfo(typeof(DocumentModel.Math.IBase))]
public interface IAccent // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
