namespace DocumentModel.Drawings;

/// <summary>
/// Audio from CD.
/// </summary>
public class AudioFromCDImpl: ModelElement<DocumentFormat.OpenXml.Drawing.AudioFromCD>, AudioFromCD
{
  /// <summary>
  /// Audio Start Time.
  /// </summary>
  public Boolean? StartTime
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList1? ExtensionList
  {
    get;
    set;
  }
  
}
