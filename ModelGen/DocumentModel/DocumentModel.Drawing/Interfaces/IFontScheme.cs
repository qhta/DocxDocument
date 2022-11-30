namespace DocumentModel.Drawing;

/// <summary>
/// Font Scheme.
/// </summary>
public interface IFontScheme // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// Major Font.
  /// </summary>
  public DocumentModel.Drawing.IMajorFont? MajorFont { get ; set; }
  
  /// <summary>
  /// Minor fonts.
  /// </summary>
  public DocumentModel.Drawing.IMinorFont? MinorFont { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
