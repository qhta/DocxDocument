namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the TimelineReferences Class.
/// </summary>
public interface ITimelineReferences // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<ITimelineReference>? TimelineReferences { get ; set; }
  
}
