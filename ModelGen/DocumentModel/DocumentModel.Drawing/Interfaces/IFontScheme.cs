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
  public DocumentModel.Drawing.IFontCollectionType? MajorFont { get ; set; }
  
  /// <summary>
  /// Minor fonts.
  /// </summary>
  public DocumentModel.Drawing.IFontCollectionType? MinorFont { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
