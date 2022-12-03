namespace DocumentModel.Presentation;

/// <summary>
/// Defines the ExtendedGuide Class.
/// </summary>
public interface ExtendedGuide // : DocumentModel.BaseTypes.ModelElement
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
  public DirectionKind? Orientation { get ; set; }
  
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
  public ColorType? ColorType { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get ; set; }
  
}
