namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the Data Class.
/// </summary>
public interface Data
{
  /// <summary>
  /// id, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? Id { get ; set; }
  
  public DocumentModel.Drawings16.Charts.NumericDimension? NumericDimension { get ; set; }
  
  public DocumentModel.Drawings16.Charts.StringDimension? StringDimension { get ; set; }
  
  public DocumentModel.Drawings16.Charts.ExtensionList? ExtensionList { get ; set; }
  
}
