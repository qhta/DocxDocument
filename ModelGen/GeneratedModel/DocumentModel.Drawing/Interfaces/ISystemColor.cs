namespace DocumentModel.Drawing;

public interface ISystemColor // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public SystemColor? Val { get ; set; }
  
  public IHexBinaryValue? LastColor { get ; set; }
  
}
