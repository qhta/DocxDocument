namespace DocumentModel.Drawings;

/// <summary>
/// Defines the MajorGridlinesGridlines Class.
/// </summary>
public class MajorGridlinesGridlinesImpl: DocumentModel.Drawings.OpenXmlGridlinesElementImpl, MajorGridlinesGridlines
{
  public override ShapeProperties2? ShapeProperties
  {
    get;
    set;
  }
  
  public override ExtensionList2? ExtensionList
  {
    get;
    set;
  }
  
}
