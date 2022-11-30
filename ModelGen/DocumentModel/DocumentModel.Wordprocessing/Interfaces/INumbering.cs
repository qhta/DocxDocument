namespace DocumentModel.Wordprocessing;

/// <summary>
/// Numbering Definitions.
/// </summary>
public interface INumbering // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.INumberingPictureBullet>? NumberingPictureBullets { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.IAbstractNum>? AbstractNums { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.INumberingInstance>? NumberingInstances { get ; set; }
  
  public System.Int32? NumberingIdMacAtCleanup { get ; set; }
  
}
