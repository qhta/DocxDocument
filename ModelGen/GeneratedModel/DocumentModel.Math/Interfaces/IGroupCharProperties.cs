namespace DocumentModel.Math;

/// <summary>
/// Group-Character Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Math.IAccentChar))]
[ChildElementInfo(typeof(DocumentModel.Math.IControlProperties))]
[ChildElementInfo(typeof(DocumentModel.Math.IPosition))]
[ChildElementInfo(typeof(DocumentModel.Math.IVerticalJustification))]
public interface IGroupCharProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Group Character (Grouping Character).
  /// </summary>
  public IAccentChar? AccentChar { get ; set; }
  
  /// <summary>
  /// Position (Group Character).
  /// </summary>
  public DocumentModel.Math.IPosition? Position { get ; set; }
  
  /// <summary>
  /// Vertical Justification.
  /// </summary>
  public IVerticalJustification? VerticalJustification { get ; set; }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public DocumentModel.Math.IControlProperties? ControlProperties { get ; set; }
  
}
