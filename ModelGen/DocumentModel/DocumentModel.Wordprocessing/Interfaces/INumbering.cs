namespace DocumentModel.Wordprocessing;

/// <summary>
/// Numbering Definitions.
/// </summary>
public interface INumbering // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public Collection<INumberingPictureBullet>? NumberingPictureBullets { get ; set; }
  
  public Collection<IAbstractNum>? AbstractNums { get ; set; }
  
  public Collection<INumberingInstance>? NumberingInstances { get ; set; }
  
  public Int32? NumberingIdMacAtCleanup { get ; set; }
  
}
