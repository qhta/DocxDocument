namespace DocumentModel.Drawing;

public interface IThemeElements // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IColorScheme? ColorScheme { get ; set; }
  
  public DocumentModel.Drawing.IFontScheme? FontScheme { get ; set; }
  
  public IFormatScheme? FormatScheme { get ; set; }
  
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
