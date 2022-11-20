namespace DocumentModel.Office2013.PowerPoint;

/// <summary>
/// Defines the ExtendedGuide Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.PowerPoint.IColorType))]
[ChildElementInfo(typeof(DocumentModel.Office2013.PowerPoint.IExtensionList))]
public interface IExtendedGuide // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public uint? Id { get ; set; }
  
  /// <summary>
  /// name, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// orient, this property is only available in Office 2013 and later.
  /// </summary>
  public DocumentModel.Presentation.DirectionValues? Orientation { get ; set; }
  
  /// <summary>
  /// pos, this property is only available in Office 2013 and later.
  /// </summary>
  public int? Position { get ; set; }
  
  /// <summary>
  /// userDrawn, this property is only available in Office 2013 and later.
  /// </summary>
  public bool? IsUserDrawn { get ; set; }
  
  /// <summary>
  /// ColorType.
  /// </summary>
  public DocumentModel.Office2013.PowerPoint.IColorType? ColorType { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2013.PowerPoint.IExtensionList? ExtensionList { get ; set; }
  
}
