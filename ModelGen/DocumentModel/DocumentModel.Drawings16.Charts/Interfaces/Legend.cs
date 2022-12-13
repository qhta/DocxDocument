namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the Legend Class.
/// </summary>
public interface Legend
{
  /// <summary>
  /// pos, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings16.Charts.SidePos? Pos { get ; set; }
  
  /// <summary>
  /// align, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings16.Charts.PosAlign? Align { get ; set; }
  
  /// <summary>
  /// overlay, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? Overlay { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Drawings16.Charts.ShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// TxPrTextBody.
  /// </summary>
  public DocumentModel.Drawings16.Charts.TxPrTextBody? TxPrTextBody { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings16.Charts.ExtensionList? ExtensionList { get ; set; }
  
}
