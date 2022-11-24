namespace DocumentModel.Presentation;

/// <summary>
/// Embedded Font.
/// </summary>
public interface IEmbeddedFont // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Embedded Font Name.
  /// </summary>
  public IFont? Font { get ; set; }
  
  /// <summary>
  /// Regular Embedded Font.
  /// </summary>
  public IRegularFont? RegularFont { get ; set; }
  
  /// <summary>
  /// Bold Embedded Font.
  /// </summary>
  public IBoldFont? BoldFont { get ; set; }
  
  /// <summary>
  /// Italic Embedded Font.
  /// </summary>
  public ItalicFont? ItalicFont { get ; set; }
  
  /// <summary>
  /// Bold Italic Embedded Font.
  /// </summary>
  public IBoldItalicFont? BoldItalicFont { get ; set; }
  
}
