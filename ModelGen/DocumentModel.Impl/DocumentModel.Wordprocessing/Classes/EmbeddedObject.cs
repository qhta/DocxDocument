namespace DocumentModel.Wordprocessing;

/// <summary>
/// Inline Embedded Object.
/// </summary>
public class EmbeddedObjectImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.EmbeddedObject>, EmbeddedObject
{
  /// <summary>
  /// anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  public String? AnchorId
  {
    get;
    set;
  }
  
  public Drawing? Drawing
  {
    get;
    set;
  }
  
  public Control? Control
  {
    get;
    set;
  }
  
  public ObjectEmbed? ObjectEmbed
  {
    get;
    set;
  }
  
  public ObjectLink? ObjectLink
  {
    get;
    set;
  }
  
}
