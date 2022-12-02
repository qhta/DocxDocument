namespace DocumentModel.Drawing;

/// <summary>
/// Legend Entry.
/// </summary>
public interface ILegendEntry // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Index.
  /// </summary>
  public UInt32? Index { get ; set; }
  
  public Boolean? Delete { get ; set; }
  
  public ITextProperties? TextProperties { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
