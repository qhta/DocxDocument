namespace DocumentModel.Drawing;

public interface IAutoNumberedBullet // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public TextAutoNumberScheme? Type { get ; set; }
  
  public int? StartAt { get ; set; }
  
}
