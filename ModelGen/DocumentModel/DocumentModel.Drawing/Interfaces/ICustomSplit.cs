namespace DocumentModel.Drawing;

/// <summary>
/// Custom Split.
/// </summary>
public interface ICustomSplit // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<UInt32>? SecondPiePoints { get ; set; }
  
}
