namespace DocumentModel.Drawing;

public interface IColorMap // : DocumentFormat.OpenXml.Drawing.ColorMappingType
{
  public DocumentModel.Drawing.ColorSchemeIndex? Background1 { get ; set; }

  public DocumentModel.Drawing.ColorSchemeIndex? Text1 { get ; set; }

  public DocumentModel.Drawing.ColorSchemeIndex? Background2 { get ; set; }

  public DocumentModel.Drawing.ColorSchemeIndex? Text2 { get ; set; }

  public DocumentModel.Drawing.ColorSchemeIndex? Accent1 { get ; set; }

  public DocumentModel.Drawing.ColorSchemeIndex? Accent2 { get ; set; }

  public DocumentModel.Drawing.ColorSchemeIndex? Accent3 { get ; set; }

  public DocumentModel.Drawing.ColorSchemeIndex? Accent4 { get ; set; }

  public DocumentModel.Drawing.ColorSchemeIndex? Accent5 { get ; set; }

  public DocumentModel.Drawing.ColorSchemeIndex? Accent6 { get ; set; }

  public DocumentModel.Drawing.ColorSchemeIndex? Hyperlink { get ; set; }

  public DocumentModel.Drawing.ColorSchemeIndex? FollowedHyperlink { get ; set; }

  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }

}
