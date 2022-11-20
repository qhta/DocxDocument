namespace DocumentModel.Math;

/// <summary>
/// Accent Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Math.IAccentChar))]
[ChildElementInfo(typeof(DocumentModel.Math.IControlProperties))]
public interface IAccentProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Accent Character.
  /// </summary>
  public IAccentChar? AccentChar { get ; set; }
  
  /// <summary>
  /// Control Properties.
  /// </summary>
  public DocumentModel.Math.IControlProperties? ControlProperties { get ; set; }
  
}
