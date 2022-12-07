namespace DocumentModel.Drawings;

/// <summary>
/// Defines the MinorGridlinesGridlines Class.
/// </summary>
public class MinorGridlinesGridlinesImpl: DocumentModel.Drawings.OpenXmlGridlinesElementImpl, MinorGridlinesGridlines
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
