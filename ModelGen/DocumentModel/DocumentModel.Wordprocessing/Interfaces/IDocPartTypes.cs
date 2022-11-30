namespace DocumentModel.Wordprocessing;

/// <summary>
/// Entry Types.
/// </summary>
public interface IDocPartTypes // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Entry Is Of All Types
  /// </summary>
  public System.Boolean? All { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.DocPartKind>? DocPartTypes { get ; set; }
  
}
