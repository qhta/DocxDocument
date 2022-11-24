namespace DocumentModel.Office2013.PowerPoint;

/// <summary>
/// Defines the ExtendedGuide Class.
/// </summary>
public interface IExtendedGuide // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  public UInt32? Id { get ; set; }
  
  /// <summary>
  /// name, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// orient, this property is only available in Office 2013 and later.
  /// </summary>
  public DirectionValues? Orientation { get ; set; }
  
  /// <summary>
  /// pos, this property is only available in Office 2013 and later.
  /// </summary>
  public Int32? Position { get ; set; }
  
  /// <summary>
  /// userDrawn, this property is only available in Office 2013 and later.
  /// </summary>
  public Boolean? IsUserDrawn { get ; set; }
  
  /// <summary>
  /// ColorType.
  /// </summary>
  public IColorType? ColorType { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
