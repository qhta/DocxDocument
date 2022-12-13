namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the OpenXmlTickMarksElement Class.
/// </summary>
public interface OpenXmlTickMarksElement
{
  /// <summary>
  /// type, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings16.Charts.TickMarksType? Type { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings16.Charts.ExtensionList? ExtensionList { get ; set; }
  
}
