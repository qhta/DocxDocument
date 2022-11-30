namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Level.
/// </summary>
public interface ILevel // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.IStringPoint>? StringPoints { get ; set; }
  
}
