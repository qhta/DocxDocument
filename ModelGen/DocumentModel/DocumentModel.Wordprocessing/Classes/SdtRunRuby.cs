namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtRunRuby Class.
/// </summary>
public class SdtRunRuby: DocumentModel.Wordprocessing.SdtElement
{
  /// <summary>
  /// SdtContentRunRuby.
  /// </summary>
  public SdtContentRunRuby? SdtContentRunRuby
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
