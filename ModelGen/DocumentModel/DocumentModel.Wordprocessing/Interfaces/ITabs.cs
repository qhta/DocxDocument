namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Tabs Class.
/// </summary>
public interface ITabs // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.ITabStop>? TabStops { get ; set; }
  
}
