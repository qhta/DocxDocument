namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the RandomIdType Class.
/// </summary>
public interface IRandomIdType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public UInt32? Val { get ; set; }
  
}
