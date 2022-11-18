namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SectionType Class.
/// </summary>
public interface ISectionType // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Section Type Setting
  /// </summary>
  public SectionMark? Val { get ; set; }
  
}
