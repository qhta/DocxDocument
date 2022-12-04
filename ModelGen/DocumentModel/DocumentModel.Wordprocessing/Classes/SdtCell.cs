namespace DocumentModel.Wordprocessing;

/// <summary>
/// Cell-Level Structured Document Tag.
/// </summary>
public class SdtCell: DocumentModel.Wordprocessing.SdtElement
{
  /// <summary>
  /// Cell-Level Structured Document Tag Content.
  /// </summary>
  public SdtContentCell? SdtContentCell
  {
    get;
    set;
  }
  
  public override SdtProperties? SdtProperties
  {
    get;
    set;
  }
  
  public override SdtEndCharProperties? SdtEndCharProperties
  {
    get;
    set;
  }
  
}
