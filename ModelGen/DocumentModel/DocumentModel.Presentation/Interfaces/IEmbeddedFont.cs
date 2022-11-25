namespace DocumentModel.Presentation;

/// <summary>
/// Embedded Font.
/// </summary>
public interface IEmbeddedFont // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Embedded Font Name.
  /// </summary>
  public DocumentModel.Presentation.IFont? Font { get ; set; }
  
  /// <summary>
  /// Regular Embedded Font.
  /// </summary>
  public DocumentModel.Presentation.IEmbeddedFontDataIdType? RegularFont { get ; set; }
  
  /// <summary>
  /// Bold Embedded Font.
  /// </summary>
  public DocumentModel.Presentation.IEmbeddedFontDataIdType? BoldFont { get ; set; }
  
  /// <summary>
  /// Italic Embedded Font.
  /// </summary>
  public DocumentModel.Presentation.IEmbeddedFontDataIdType? ItalicFont { get ; set; }
  
  /// <summary>
  /// Bold Italic Embedded Font.
  /// </summary>
  public DocumentModel.Presentation.IEmbeddedFontDataIdType? BoldItalicFont { get ; set; }
  
}
