namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the SectionSlideIdListEntry Class.
/// </summary>
public interface ISectionSlideIdListEntry // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public System.UInt32? Id { get ; set; }
  
}
