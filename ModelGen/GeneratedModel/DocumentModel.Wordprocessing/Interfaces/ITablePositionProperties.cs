namespace DocumentModel.Wordprocessing;

public interface ITablePositionProperties // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public short? LeftFromText { get ; set; }
  
  public short? RightFromText { get ; set; }
  
  public short? TopFromText { get ; set; }
  
  public short? BottomFromText { get ; set; }
  
  public DocumentModel.Wordprocessing.VerticalAnchor? VerticalAnchor { get ; set; }
  
  public DocumentModel.Wordprocessing.HorizontalAnchor? HorizontalAnchor { get ; set; }
  
  public DocumentModel.Wordprocessing.HorizontalAlignment? TablePositionXAlignment { get ; set; }
  
  public int? TablePositionX { get ; set; }
  
  public DocumentModel.Wordprocessing.VerticalAlignment? TablePositionYAlignment { get ; set; }
  
  public int? TablePositionY { get ; set; }
  
}
