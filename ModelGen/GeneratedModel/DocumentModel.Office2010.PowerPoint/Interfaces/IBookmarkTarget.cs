namespace DocumentModel.Office2010.PowerPoint;

public interface IBookmarkTarget // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public uint? ShapeId { get ; set; }
  
  public string? BookmarkName { get ; set; }
  
}
