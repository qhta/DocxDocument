namespace DocumentModel.Drawing;

/// <summary>
/// Tab List.
/// </summary>
public interface ITabStopList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.ITabStop>? TabStops { get ; set; }
  
}
