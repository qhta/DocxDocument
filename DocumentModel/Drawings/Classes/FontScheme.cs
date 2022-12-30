namespace DocumentModel.Drawings;

/// <summary>
/// Font Scheme.
/// </summary>
public partial class FontScheme
{
  /// <summary>
  /// Name
  /// </summary>
  public String? Name { get; set; }
  
  /// <summary>
  /// Major Font.
  /// </summary>
  public DocumentModel.Drawings.MajorFont? MajorFont { get; set; }
  
  /// <summary>
  /// Minor fonts.
  /// </summary>
  public DocumentModel.Drawings.MinorFont? MinorFont { get; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get; set; }
  
}
