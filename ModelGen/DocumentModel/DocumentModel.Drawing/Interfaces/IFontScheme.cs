namespace DocumentModel.Drawing;

/// <summary>
/// Font Scheme.
/// </summary>
public interface IFontScheme // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Name
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// Major Font.
  /// </summary>
  public IMajorFont? MajorFont { get ; set; }
  
  /// <summary>
  /// Minor fonts.
  /// </summary>
  public IMinorFont? MinorFont { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
