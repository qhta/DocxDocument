namespace DocumentModel.Drawing;

/// <summary>
/// Tab List.
/// </summary>
public interface ITabStopList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<ITabStop>? TabStops { get ; set; }
  
}
