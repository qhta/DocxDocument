namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ObjectDefaults Class.
/// </summary>
public partial class ObjectDefaults
{
  /// <summary>
  /// Shape Default.
  /// </summary>
  public DocumentModel.Drawings.ShapeDefault? ShapeDefault { get; set; }
  
  /// <summary>
  /// Line Default.
  /// </summary>
  public DocumentModel.Drawings.LineDefault? LineDefault { get; set; }
  
  /// <summary>
  /// Text Default.
  /// </summary>
  public DocumentModel.Drawings.TextDefault? TextDefault { get; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get; set; }
  
}
