namespace DocumentModel.Drawing;

/// <summary>
/// Legend Entry.
/// </summary>
public interface ILegendEntry // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Index.
  /// </summary>
  public System.UInt32? Index { get ; set; }
  
  public System.Boolean? Delete { get ; set; }
  
  public DocumentModel.Drawing.ITextProperties? TextProperties { get ; set; }
  
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
