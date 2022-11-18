namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the SectionSlideIdListEntry Class.
/// </summary>
public interface ISectionSlideIdListEntry // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public uint? Id { get ; set; }
  
}
