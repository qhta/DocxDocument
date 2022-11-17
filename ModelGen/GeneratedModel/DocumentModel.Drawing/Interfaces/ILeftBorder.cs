namespace DocumentModel.Drawing;

public interface ILeftBorder // : DocumentFormat.OpenXml.Drawing.ThemeableLineStyleType
{
  public DocumentModel.Drawing.IOutline? Outline { get ; set; }

  public DocumentModel.Drawing.ILineReference? LineReference { get ; set; }

}
