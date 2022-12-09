namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ChartTitle Class.
/// </summary>
public interface ChartTitle
{
  /// <summary>
  /// pos, this property is only available in Office 2016 and later.
  /// </summary>
  public SidePos? Pos { get ; set; }
  
  /// <summary>
  /// align, this property is only available in Office 2016 and later.
  /// </summary>
  public PosAlign? Align { get ; set; }
  
  /// <summary>
  /// overlay, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? Overlay { get ; set; }
  
  /// <summary>
  /// Text.
  /// </summary>
  public Text2? Text { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public ShapeProperties8? ShapeProperties { get ; set; }
  
  /// <summary>
  /// TxPrTextBody.
  /// </summary>
  public TxPrTextBody? TxPrTextBody { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList2? ExtensionList { get ; set; }
  
}
