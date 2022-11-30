namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the TimelineReferences Class.
/// </summary>
public interface ITimelineReferences // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2013.Excel.ITimelineReference>? TimelineReferences { get ; set; }
  
}
