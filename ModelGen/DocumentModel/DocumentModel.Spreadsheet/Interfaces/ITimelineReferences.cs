namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the TimelineReferences Class.
/// </summary>
public interface ITimelineReferences // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.ITimelineReference>? TimelineReferences { get ; set; }
  
}
