namespace DocumentModel.Wordprocessing;

/// <summary>
/// Numbering Definitions.
/// </summary>
public interface Numbering
{
  public Collection<DocumentModel.Wordprocessing.NumberingPictureBullet>? NumberingPictureBullets { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.AbstractNum>? AbstractNums { get ; set; }
  
  public Collection<DocumentModel.Wordprocessing.NumberingInstance>? NumberingInstances { get ; set; }
  
  public Int32? NumberingIdMacAtCleanup { get ; set; }
  
}
