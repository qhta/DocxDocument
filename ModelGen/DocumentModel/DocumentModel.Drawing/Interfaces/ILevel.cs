namespace DocumentModel.Drawing;

/// <summary>
/// Level.
/// </summary>
public interface ILevel // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IStringPoint>? StringPoints { get ; set; }
  
}
