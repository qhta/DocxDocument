namespace DocumentModel.Drawings;


/// <summary>
///   This element allows for the definition of default shape, line, and textbox formatting properties.  An application can use this information to format a shape (or text) initially on insertion into a document.
/// </summary>
public partial class ObjectDefaults
{
  
  /// <summary>
  ///   Shape Default.
  /// </summary>
  public ShapeDefault? ShapeDefault { get; set; }
  
  
  /// <summary>
  ///   Line Default.
  /// </summary>
  public LineDefault? LineDefault { get; set; }
  
  
  /// <summary>
  ///   Text Default.
  /// </summary>
  public TextDefault? TextDefault { get; set; }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
  
}
