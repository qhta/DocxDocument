namespace DocumentModel.Drawing;

public interface IBottomBorder // : DocumentFormat.OpenXml.Drawing.ThemeableLineStyleType
{
  public DocumentModel.Drawing.IOutline? Outline { get ; set; }
  
  public DocumentModel.Drawing.ILineReference? LineReference { get ; set; }
  
}
