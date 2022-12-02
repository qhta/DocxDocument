namespace DocumentModel.Drawing;

/// <summary>
/// Level.
/// </summary>
public interface ILevel // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IStringPoint>? StringPoints { get ; set; }
  
}
