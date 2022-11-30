namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the DateAxExtensionList Class.
/// </summary>
public interface IDateAxExtensionList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.IDateAxExtension>? DateAxExtensions { get ; set; }
  
}
