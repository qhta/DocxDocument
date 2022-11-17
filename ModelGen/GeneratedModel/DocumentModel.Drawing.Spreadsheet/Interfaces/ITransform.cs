namespace DocumentModel.Drawing.Spreadsheet;

public interface ITransform // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public int? Rotation { get ; set; }
  
  public bool? HorizontalFlip { get ; set; }
  
  public bool? VerticalFlip { get ; set; }
  
  public IOffset? Offset { get ; set; }
  
  public IExtents? Extents { get ; set; }
  
}
