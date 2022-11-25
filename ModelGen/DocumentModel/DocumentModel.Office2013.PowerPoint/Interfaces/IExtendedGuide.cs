namespace DocumentModel.Office2013.PowerPoint;

/// <summary>
/// Defines the ExtendedGuide Class.
/// </summary>
public interface IExtendedGuide // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public System.UInt32? Id { get ; set; }
  
  /// <summary>
  /// name, this property is only available in Office 2013 and later.
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// orient, this property is only available in Office 2013 and later.
  /// </summary>
  public DocumentModel.Presentation.DirectionKind? Orientation { get ; set; }
  
  /// <summary>
  /// pos, this property is only available in Office 2013 and later.
  /// </summary>
  public System.Int32? Position { get ; set; }
  
  /// <summary>
  /// userDrawn, this property is only available in Office 2013 and later.
  /// </summary>
  public System.Boolean? IsUserDrawn { get ; set; }
  
  /// <summary>
  /// ColorType.
  /// </summary>
  public DocumentModel.Office2013.PowerPoint.IColorType? ColorType { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
